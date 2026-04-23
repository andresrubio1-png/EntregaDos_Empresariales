import { useState, useEffect } from "react";
import * as passiveService from "../services/passiveService";
import * as manufacturerService from "../services/manufacturerService";

const packageTypes = ["SMD", "DIP", "SIP", "QFP", "BGA", "SOT", "TO", "AXIAL"];

function UpdatePassive() {
    const [id, setId] = useState("");
    const [form, setForm] = useState(null);
    const [manufacturers, setManufacturers] = useState([]);
    useEffect(() => {
        manufacturerService.getAll()
            .then(res => setManufacturers(res.data))
            .catch(err => console.error(err));
    }, []);
    const handleSearch = () => {
        if (!id) {
            alert("Ingrese un ID");
            return;
        }

        passiveService.getById(id)
            .then(res => {
                const data = res.data;

                setForm({
                    pinCount: data.pinCount,
                    packageType: data.packageType,
                    voltage: data.voltage,
                    tolerance: data.tolerance,
                    manufacturerId: data.manufacturer?.id,
                    value: data.nominalValue?.value,
                    unit: data.nominalValue?.unit
                });
            })
            .catch(() => {
                alert("No encontrado");
                setForm(null);
            });
    };
    const handleChange = (e) => {
        setForm({
            ...form,
            [e.target.name]: e.target.value
        });
    };

    const handleUpdate = () => {
        const payload = {
            pinCount: parseInt(form.pinCount),
            packageType: form.packageType,
            voltage: parseFloat(form.voltage),
            tolerance: parseFloat(form.tolerance),
            manufacturerId: parseInt(form.manufacturerId),
            nominalValue: {
                value: parseFloat(form.value),
                unit: form.unit
            }
        };

        passiveService.update(id, payload)
            .then(() => alert("Actualizado correctamente"))
            .catch(err => console.error(err));
    };

    return (
        <div>
            <h2>Actualizar Componente</h2>

            <input
                placeholder="Ingrese ID"
                value={id}
                onChange={(e) => setId(e.target.value)}
            />

            <button onClick={handleSearch}>Buscar</button>

            <hr />

            {form && (
                <div>
                    <label>Num. Pines</label>
                    <input name="pinCount" value={form.pinCount} onChange={handleChange} />
                    <label>Encapsulado</label>
                    <select name="packageType" value={form.packageType} onChange={handleChange}>
                        {packageTypes.map(p => (
                            <option key={p} value={p}>{p}</option>
                        ))}
                    </select>
                    <label>Voltaje</label>
                    <input name="voltage" value={form.voltage} onChange={handleChange} />
                    <label>Tolerancia</label>
                    <input name="tolerance" value={form.tolerance} onChange={handleChange} />
                    <label>Fabricante</label>
                    <select
                        name="manufacturerId"
                        value={form.manufacturerId}
                        onChange={handleChange}
                    >
                        {manufacturers.map(m => (
                            <option key={m.id} value={m.id}>
                                {m.name}
                            </option>
                        ))}
                    </select>
                    <label>Valor Nominal</label>
                    <input name="value" value={form.value} onChange={handleChange} />
                    <label>Unidad</label>
                    <input name="unit" value={form.unit} onChange={handleChange} />

                    <button onClick={handleUpdate}>
                        Actualizar
                    </button>

                </div>
            )}
        </div>
    );
}

export default UpdatePassive;
