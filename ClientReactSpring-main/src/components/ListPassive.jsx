import { useEffect, useState } from "react";
import * as passiveService from "../services/passiveService";

function ListPassive() {
    const [data, setData] = useState([]);

    useEffect(() => {
        passiveService.getAll()
            .then(res => setData(res.data))
            .catch(err => console.error(err));
    }, []);

    return (
        <div>
            <h2>Lista de Componentes</h2>

            {data.length === 0 ? (
                <p>No hay datos</p>
            ) : (
                <ul>
                    {data.map(c => (
                        <li key={c.id}>
                            {c.id} - {c.pinCount} - {c.packageType} - {c.voltage}V - {c.tolerance} - {c.nominalValue.value}
                            - {c.manufacturer.name} - {c.manufacturer.country} - {c.createdAt.split("T")[0]}
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
}

export default ListPassive;