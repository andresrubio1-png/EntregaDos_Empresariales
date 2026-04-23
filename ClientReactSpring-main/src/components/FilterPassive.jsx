import { useState } from "react";
import * as passiveService from "../services/passiveService";

const packageTypes = ["SMD", "DIP", "SIP", "QFP", "BGA", "SOT", "TO", "AXIAL"];

function FilterPassive() {
  const [filterMode, setFilterMode] = useState("type");

  const [packageType, setPackageType] = useState("");
  const [minVoltage, setMinVoltage] = useState("");
  const [maxVoltage, setMaxVoltage] = useState("");

  const [data, setData] = useState([]);

const handleFilter = () => {

  // FILTRO POR TIPO
  if (filterMode === "type") {
    if (!packageType) {
      alert("Seleccione un tipo");
      return;
    }

    passiveService.getByPackageType(packageType)
      .then(res => {
        console.log("RESPUESTA:", res.data);
        setData(res.data);
      })
      .catch(err => console.error(err));

    return; // 🔥 IMPORTANTE
  }

  // FILTRO POR VOLTAJE
  if (filterMode === "voltage") {
    if (!minVoltage || !maxVoltage) {
      alert("Ingrese ambos valores");
      return;
    }

    if (Number(minVoltage) > Number(maxVoltage)) {
      alert("El mínimo no puede ser mayor que el máximo");
      return;
    }

    passiveService.getByVoltageRange(minVoltage, maxVoltage)
      .then(res => {
        console.log("RESPUESTA:", res.data);
        setData(res.data);
      })
      .catch(err => console.error(err));

    return;
  }
};

  return (
    <div style={{ maxWidth: "500px", margin: "auto" }}>
      <h2>Filtrar Componentes</h2>

      {/* 🔘 Selección de modo */}
      <div style={{ marginBottom: "15px" }}>
        <label>
          <input
            type="radio"
            checked={filterMode === "type"}
            onChange={() => {
              setFilterMode("type");
              setMinVoltage("");
              setMaxVoltage("");
            }}
          />
          Por tipo
        </label>

        <label style={{ marginLeft: "15px" }}>
          <input
            type="radio"
            checked={filterMode === "voltage"}
            onChange={() => {
              setFilterMode("voltage");
              setPackageType("");
            }}
          />
          Por voltaje
        </label>
      </div>

      {/* 📦 FILTRO POR TIPO */}
      {filterMode === "type" && (
        <div style={{ marginBottom: "15px" }}>
          <label>Tipo de encapsulado:</label>
          <br />
          <select
            value={packageType}
            onChange={(e) => setPackageType(e.target.value)}
            style={{ width: "100%", padding: "5px" }}
          >
            <option value="">Seleccione tipo</option>
            {packageTypes.map(p => (
              <option key={p} value={p}>{p}</option>
            ))}
          </select>
        </div>
      )}

      {/* ⚡ FILTRO POR VOLTAJE */}
      {filterMode === "voltage" && (
        <div style={{ marginBottom: "15px" }}>
          <label>Voltaje mínimo:</label>
          <input
            type="number"
            value={minVoltage}
            onChange={(e) => setMinVoltage(e.target.value)}
            style={{ width: "100%", marginBottom: "10px" }}
          />

          <label>Voltaje máximo:</label>
          <input
            type="number"
            value={maxVoltage}
            onChange={(e) => setMaxVoltage(e.target.value)}
            style={{ width: "100%" }}
          />
        </div>
      )}

      {/* 🔘 BOTÓN */}
      <button
        onClick={handleFilter}
        style={{
          width: "100%",
          padding: "10px",
          background: "#e63946",
          color: "white",
          border: "none",
          borderRadius: "5px"
        }}
      >
        Filtrar
      </button>

      <hr />

      {/* 📊 RESULTADOS */}
      {data.length === 0 ? (
        <p>Realiza un filtro para ver resultados</p>
      ) : (
        <div>
          {data.map(c => (
            <div
              key={c.id}
              style={{
                border: "1px solid #ccc",
                padding: "10px",
                marginBottom: "10px",
                borderRadius: "8px"
              }}
            >
              <p><strong>ID:</strong> {c.id}</p>
              <p><strong>Tipo:</strong> {c.packageType}</p>
              <p><strong>Voltaje:</strong> {c.voltage} V</p>
              <p><strong>Pines:</strong> {c.pinCount}</p>
              <p><strong>Fabricante:</strong> {c.manufacturer?.name}</p>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}

export default FilterPassive;