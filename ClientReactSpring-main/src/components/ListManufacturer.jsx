import { useEffect, useState } from "react";
import * as manufacturerService from "../services/manufacturerService";

function ListManufacturer() {
    const [data, setData] = useState([]);

    useEffect(() => {
        manufacturerService.getAll()
            .then(res => setData(res.data))
            .catch(err => console.error(err));
    }, []);

    return (
        <div>
            <h2>Lista de Fabricantes</h2>
            {data.length === 0 ? (
                <p>No hay datos</p>
            ) : (
                <ul>
                    {data.map(m => (
                        <li key={m.id}>
                            {m.id} - {m.name} - {m.country} - {m.averageLeadTime} días - {m.createdAt?.split("T")[0]}
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
}

export default ListManufacturer;