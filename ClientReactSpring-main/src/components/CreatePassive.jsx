import { useEffect, useState } from "react";
import * as passiveService from "../services/passiveService";
import * as manufacturerService from "../services/manufacturerService";

function CreatePassive() {
    const packageTypes = ["SMD", "DIP", "SIP", "QFP", "BGA", "SOT", "TO", "AXIAL"];
    const [form, setForm] = useState({
        pinCount: "",
        packageType: "",
        voltage: "",
        tolerance: "",
        manufacturerId: "",
        value: "",
        unit: ""
    });
    //Cargar Fabricantes
    const [manufacturers, setManufacturers] = useState([]);
    useEffect(() => {
        manufacturerService.getAll()
            .then(res => setManufacturers(res.data))
            .catch(err => console.error(err));
    }, []);
    //Inputs
    const handleChange = (e) => {
        setForm({
            ...form,
            [e.target.name]: e.target.value
        });
    };

    //Post
    const handleSubmit = (e) => {
        e.preventDefault();
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
        passiveService.create(payload)
            .then(() => {
                alert("Componente Creado");
            })
            .catch(err => console.error(err));
    };


    return (
        <form onSubmit={handleSubmit}>
            <h2>Crear Componente</h2>
            <input name="pinCount" placeholder="Pines" onChange={handleChange} />
            <select name="packageType" onChange={handleChange}>
                <option value="">Seleccione tipo</option>

                {packageTypes.map(type => (
                    <option key={type} value={type}>
                        {type}
                    </option>
                ))}
            </select>
            <input name="voltage" placeholder="Voltaje" onChange={handleChange} />
            <input name="tolerance" placeholder="Tolerancia" onChange={handleChange} />

            {/* SELECT DE FABRICANTES*/}
            <select name="manufacturerId" onChange={handleChange}>
                <option value="">Seleccione fabricante</option>
                {manufacturers.map(m => (
                    <option key={m.id} value={m.id}>
                        {m.name}
                    </option>
                ))}
            </select>

            {/* VALOR NOMINAL */}
            <input name="value" placeholder="Valor nominal" onChange={handleChange} />
            <input name="unit" placeholder="Unidad (ohm, F...)" onChange={handleChange} />

            <button type="submit">Crear</button>
        </form>

    );
}


export default CreatePassive;