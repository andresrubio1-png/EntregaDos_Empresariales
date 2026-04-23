import { useState } from "react";
import * as manufacturerService from "../services/manufacturerService";

function SearchManufacturer() {
    const [id, setId] = useState("");
    const [result, setResult] = useState(null);

    const handleSearch = () => {
        manufacturerService.getById(id)
            .then(res => setResult(res.data))
            .catch(() => {
                alert("No encontrado");
                setResult(null);
            });
    };

    return (
        <div>
            <h2>Buscar Fabricante por ID</h2>
            <input
                placeholder="Ingrese ID"
                value={id}
                onChange={(e) => setId(e.target.value)}
            />
            <button onClick={handleSearch}>Buscar</button>
            <hr />
            {result && (
                <div>
                    <p><strong>ID:</strong> {result.id}</p>
                    <p><strong>Nombre:</strong> {result.name}</p>
                    <p><strong>País:</strong> {result.country}</p>
                    <p><strong>Tiempo de entrega:</strong> {result.averageLeadTime} días</p>
                    <p><strong>Fecha:</strong> {result.createdAt?.split("T")[0]}</p>
                </div>
            )}
        </div>
    );
}

export default SearchManufacturer;