import { useState, createContext } from 'react';

export const FinancialStatementsContext = createContext();

function FinancialStatementsContextProvider(props) {
  const [financialStatements, setFinancialStatements ] = useState([]);
  
  const value = {financialStatements, setFinancialStatements}

  return (
    <FinancialStatementsContext.Provider value={value}>
      {props.children}
    </FinancialStatementsContext.Provider>
  )
}

export default FinancialStatementsContextProvider