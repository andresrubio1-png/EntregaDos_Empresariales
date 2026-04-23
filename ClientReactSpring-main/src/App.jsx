import { BrowserRouter, Routes, Route, Link } from "react-router-dom";

import PassiveComponentsPage from "./pages/PassiveComponentsPage";
import ManufacturersPage from "./pages/ManufacturersPage";

function App() {
  return (
    <BrowserRouter>
      <div>
        
        <Link to="/manufacturers">
            Fabricantes
          </Link>

        <nav style={{ marginBottom: "20px" }}>
          <Link to="/components" style={{ marginRight: "10px" }}>
             Componentes
          </Link>

          
        </nav>


        <Routes>
          <Route path="/components" element={<PassiveComponentsPage />} />
          <Route path="/manufacturers" element={<ManufacturersPage />} />

          {/* ruta por defecto */}
          <Route path="*" element={<PassiveComponentsPage />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;