import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Home from '../Components/Home/Home';
import FinancialStatementsContextProvider from '../contexts/FinancialStatementsContext';
import NavBar from '../Components/MaterialUI/AppBar';
import './App.css';
import CompanyDashboard from '../Components/CompanyDashboard/CompanyDashboard';

function App() {
  return (
    <FinancialStatementsContextProvider>
      <div className="App">
        <NavBar></NavBar>
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Home></Home>}></Route>
            <Route path="/companyDashboard" element={<CompanyDashboard></CompanyDashboard>}></Route>
          </Routes>
        </BrowserRouter>
      </div>
    </FinancialStatementsContextProvider>
  );
}

export default App;
