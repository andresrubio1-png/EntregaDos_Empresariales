import { useState } from "react";
import * as manufacturerService from "../services/manufacturerService";

function UpdateManufacturer() {
    const [id, setId] = useState("");
    const [form, setForm] = useState(null);

    const handleSearch = () => {
        if (!id) { alert("Ingrese un ID"); return; }
        manufacturerService.getById(id)
            .then(res => {
                const d = res.data;
                setForm({
                    name: d.name,
                    country: d.country,
                    averageLeadTime: d.averageLeadTime
                });
            })
            .catch(() => { alert("No encontrado"); setForm(null); });
    };

    const handleChange = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });
    };

    const handleUpdate = () => {
        const payload = {
            name: form.name,
            country: form.country,
            averageLeadTime: parseFloat(form.averageLeadTime)
        };
        manufacturerService.update(id, payload)
            .then(() => alert("Actualizado correctamente"))
            .catch(err => console.error(err));
    };

    return (
        <div>
            <h2>Actualizar Fabricante</h2>
            <input
                placeholder="Ingrese ID"
                value={id}
                onChange={(e) => setId(e.target.value)}
            />
            <button onClick={handleSearch}>Buscar</button>
            <hr />
            {form && (
                <div>
                    <label>Nombre</label>
                    <input name="name" value={form.name} onChange={handleChange} />
                    <label>País</label>
                    <input name="country" value={form.country} onChange={handleChange} />
                    <label>Tiempo de entrega (días)</label>
                    <input name="averageLeadTime" value={form.averageLeadTime} onChange={handleChange} />
                    <button onClick={handleUpdate}>Actualizar</button>
                </div>
            )}
        </div>
    );
}

export default UpdateManufacturer;