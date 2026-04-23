import { useState } from "react";

import ListManufacturer from "../components/ListManufacturer";
import CreateManufacturer from "../components/CreateManufacturer";
import SearchManufacturer from "../components/SearchManufacturer";
import UpdateManufacturer from "../components/UpdateManufacturer";
import DeleteManufacturer from "../components/DeleteManufacturer";

function ManufacturersPage() {
    const [view, setView] = useState("list");

    return (
        <div>
            <h1>Fabricantes</h1>

            <button onClick={() => setView("create")}>Crear</button>
            <button onClick={() => setView("search")}>Buscar</button>
            <button onClick={() => setView("delete")}>Eliminar</button>
            <button onClick={() => setView("update")}>Actualizar</button>
            <button onClick={() => setView("list")}>Listar</button>
            

            <hr />

            {view === "create" && <CreateManufacturer />}
            {view === "search" && <SearchManufacturer />}
            {view === "delete" && <DeleteManufacturer />}
            {view === "update" && <UpdateManufacturer />}
            {view === "list" && <ListManufacturer />}
        </div>
    );
}

export default ManufacturersPage;