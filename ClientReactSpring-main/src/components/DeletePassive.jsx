import { useState } from "react";
import * as passiveService from "../services/passiveService";

function DeletePassive() {
    const [id, setId] = useState("");
    const [result, setResult] = useState(null);

    const handleSearch = () => {
        if (!id) {
            alert("Ingrese un ID");
            return;
        }

        passiveService.getById(id)
            .then(res => setResult(res.data))
            .catch(() => {
                alert("No encontrado");
                setResult(null);
            });
    };

    const handleDelete = () => {
        const confirmDelete = window.confirm("¿Seguro que deseas eliminar este componente?");
        if (!confirmDelete) return;

        passiveService.remove(id)
            .then(() => {
                alert("Eliminado correctamente");
                setResult(null);
                setId("");
            })
            .catch(err => console.error(err));
    };

    return (
        <div>
            <h2>Eliminar Componente</h2>

            <input
                placeholder="Ingrese ID"
                value={id}
                onChange={(e) => setId(e.target.value)}
            />

            <button onClick={handleSearch}>Buscar</button>

            <hr />

            {result && (
                <div style={{ border: "1px solid red", padding: "10px" }}>
                    <p><strong>Detalles del componente</strong></p>
                    <p><strong>ID:</strong> {result.id}</p>
                    <p><strong>Pines:</strong> {result.pinCount}</p>
                    <p><strong>Encapsulado:</strong> {result.packageType}</p>
                    <p><strong>Voltaje:</strong> {result.voltage}</p>
                    <p><strong>Tolerancia:</strong> {result.tolerance}</p>
                    <p><strong>Valor Nominal:</strong> {result.nominalValue.value} , {result.nominalValue.unit}</p>
                    <p><strong>Fecha:</strong> {result.createdAt.split("T")[0]}</p>
                    <p>-------------------------------------------------------------------------------</p>
                    <p><strong>Detalles del fabricante</strong></p>
                    <p><strong>Fabricante:</strong> {result.manufacturer?.name}</p>
                    <p><strong>Pais:</strong> {result.manufacturer?.country}</p>
                    <p><strong>Tiempo de entrega:</strong> {result.manufacturer?.averageLeadTime}</p>


                    <button onClick={handleDelete} style={{ background: "red", color: "white" }}>
                        Confirmar Eliminación
                    </button>
                </div>
            )}
        </div>
    );
}

export default DeletePassive;