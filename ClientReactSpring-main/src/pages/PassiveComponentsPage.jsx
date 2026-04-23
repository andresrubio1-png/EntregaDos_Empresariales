import { useState } from "react";

import ListPassive from "../components/ListPassive";
import CreatePassive from "../components/CreatePassive";
import SearchPassive from "../components/SearchPassive";
import UpdatePassive from "../components/UpdatePassive";
import FilterPassive from "../components/FilterPassive";
import DeletePassive from "../components/DeletePassive";

function PassiveComponentsPage() {
    const [view, setView] = useState("list");
    return (
        <div>
            <h1>Componentes</h1>

            <button onClick={() => setView("create")}>Crear</button>
            <button onClick={() => setView("search")}>Buscar</button>
            <button onClick={() => setView("delete")}>Eliminar</button>
            <button onClick={() => setView("update")}>Actualizar</button>
            <button onClick={() => setView("list")}>Listar</button>
            <button onClick={() => setView("filter")}>Filtrar</button>

            <hr />

            {view === "create" && <CreatePassive />}
            {view === "search" && <SearchPassive />}
            {view === "delete" && <DeletePassive />}
            {view === "update" && <UpdatePassive />}
            {view === "filter" && <FilterPassive />}
            {view === "list" && <ListPassive />}
        </div>
    );

}
export default PassiveComponentsPage;