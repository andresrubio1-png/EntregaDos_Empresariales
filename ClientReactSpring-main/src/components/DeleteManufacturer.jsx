import { useState } from "react";
import * as manufacturerService from "../services/manufacturerService";

function DeleteManufacturer() {
    const [id, setId] = useState("");
    const [result, setResult] = useState(null);

    const handleSearch = () => {
        if (!id) { alert("Ingrese un ID"); return; }
        manufacturerService.getById(id)
            .then(res => setResult(res.data))
            .catch(() => { alert("No encontrado"); setResult(null); });
    };

    const handleDelete = () => {
        if (!window.confirm("¿Seguro que deseas eliminar este fabricante?")) return;
        manufacturerService.remove(id)
            .then(() => { alert("Eliminado correctamente"); setResult(null); setId(""); })
            .catch(err => console.error(err));
    };

    return (
        <div>
            <h2>Eliminar Fabricante</h2>
            <input
                placeholder="Ingrese ID"
                value={id}
                onChange={(e) => setId(e.target.value)}
            />
            <button onClick={handleSearch}>Buscar</button>
            <hr />
            {result && (
                <div style={{ border: "1px solid red", padding: "10px" }}>
                    <p><strong>ID:</strong> {result.id}</p>
                    <p><strong>Nombre:</strong> {result.name}</p>
                    <p><strong>País:</strong> {result.country}</p>
                    <p><strong>Tiempo de entrega:</strong> {result.averageLeadTime} días</p>
                    <button onClick={handleDelete} style={{ background: "red", color: "white" }}>
                        Confirmar Eliminación
                    </button>
                </div>
            )}
        </div>
    );
}

export default DeleteManufacturer;