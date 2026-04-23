import { useState } from "react";
import * as manufacturerService from "../services/manufacturerService";

function CreateManufacturer() {
    const [form, setForm] = useState({
        name: "",
        country: "",
        averageLeadTime: ""
    });

    const handleChange = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        const payload = {
            name: form.name,
            country: form.country,
            averageLeadTime: parseFloat(form.averageLeadTime)
        };
        manufacturerService.create(payload)
            .then(() => alert("Fabricante creado"))
            .catch(err => console.error(err));
    };

    return (
        <form onSubmit={handleSubmit}>
            <h2>Crear Fabricante</h2>
            <input name="name" placeholder="Nombre" onChange={handleChange} />
            <input name="country" placeholder="País" onChange={handleChange} />
            <input name="averageLeadTime" placeholder="Tiempo de entrega (días)" onChange={handleChange} />
            <button type="submit">Crear</button>
        </form>
    );
}

export default CreateManufacturer;