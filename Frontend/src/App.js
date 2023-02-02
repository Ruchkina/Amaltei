import './App.css';
import {
  Routes,
  Route,
} from "react-router-dom";
import Index from './components/Index';
import Party from './components/Party';
import About from './components/About';

function App() {
  return (
    <div className="Politikisto">
      <Routes>
        <Route path="/" element={ <Index />} /> 
        <Route path="/about" element={<About />} />
        <Route path="/party/:partyId" element={<Party />} />
      </Routes>
    </div>
  );
}

export default App;
