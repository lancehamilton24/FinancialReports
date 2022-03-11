import Home from '../Components/Home/Home';
import FinancialStatementsContextProvider from '../contexts/FinancialStatementsContext';
import NavBar from '../Components/MaterialUI/AppBar';
import './App.css';

function App() {
  return (
    <FinancialStatementsContextProvider>
    <div className="App">
      <NavBar></NavBar>
      <Home></Home>
    </div>
    </FinancialStatementsContextProvider>
  );
}

export default App;
