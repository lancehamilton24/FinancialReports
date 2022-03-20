import React, { useState } from 'react'
import Button from '@mui/material/Button';
import ButtonGroup from '@mui/material/ButtonGroup';
import { FinancialStatementsContext } from '../../contexts/FinancialStatementsContext';
import { useNavigate } from 'react-router-dom';
import CompanyProfile from '../CompanyInfo/CompanyProfile/CompanyProfile';
import IncomeStatement from '../CompanyInfo/IncomeStatement/IncomeStatement';
import BalanceSheet from '../CompanyInfo/BalanceSheet/BalanceSheet';
import CashFlowStatement from '../CompanyInfo/CashFlowStatement/CashFlowStatement';
import CompetitiveAdvantageRatios from '../CompanyInfo/CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';


function CompanyDashboard() {
  const [component, setComponent] = useState("")
  const [financialData, setFinancialData] = useState()

  function clickHandler(component) {
    switch (component) {
      case "incomeStatements":
        setFinancialData(<IncomeStatement />)
        break
      case "balanceSheets":
        setFinancialData(<BalanceSheet />)
        break
      case "cashFlows":
        setFinancialData(<CashFlowStatement />)
        break
      case "competitiveAdvantageRatios":
        setFinancialData(<CompetitiveAdvantageRatios />)
        break
    }
  }

  return (
    <div>
      <div className="panels">
        <div className="panel-financialstatements">
          <CompanyProfile></CompanyProfile>
          <div>
            <ButtonGroup variant="contained" aria-label="outlined primary button group">
              <Button onClick={() => clickHandler("incomeStatements")}>Income Statements</Button>
              <Button onClick={() => clickHandler("balanceSheets")}>Balance Sheets</Button>
              <Button onClick={() => clickHandler("cashFlows")}>Cash Flow Statements</Button>
              <Button onClick={() => clickHandler("competitiveAdvantageRatios")}>Competitive Advantage Ratios</Button>
            </ButtonGroup>
          </div>
          {financialData}
        </div>
      </div>
    </div>
  );
}

export default CompanyDashboard