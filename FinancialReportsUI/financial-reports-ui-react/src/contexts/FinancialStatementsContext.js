import { useState, createContext } from 'react';
import incomeStatementRequest from '../Data/financialStatementsRequest';

export const FinancialStatementsContext = createContext();

function FinancialStatementsContextProvider(props) {
  const [financialStatements, setFinancialStatements ] = useState([]);

  const getAllFinancialStatements = (companyTicker) => {
    incomeStatementRequest.getAllFinancialStatements(companyTicker).then((financialStatements) => {
      setFinancialStatements(financialStatements);
    })
  }

  const clearFinancialStatements = () => {
      setFinancialStatements([]);
  }

  const value = {financialStatements, getAllFinancialStatements, clearFinancialStatements}

  return (
    <FinancialStatementsContext.Provider value={value}>
      {props.children}
    </FinancialStatementsContext.Provider>
  )
}

export default FinancialStatementsContextProvider