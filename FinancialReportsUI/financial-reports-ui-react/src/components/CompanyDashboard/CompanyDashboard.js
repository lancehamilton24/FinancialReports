import React, { useContext } from 'react'
import { FinancialStatementsContext } from '../../contexts/FinancialStatementsContext';
import { useNavigate } from 'react-router-dom';
import CompanyProfile from '../CompanyInfo/CompanyProfile/CompanyProfile';
import IncomeStatement from '../CompanyInfo/IncomeStatement/IncomeStatement';
import BalanceSheet from '../CompanyInfo/BalanceSheet/BalanceSheet';
import CashFlowStatement from '../CompanyInfo/CashFlowStatement/CashFlowStatement';
import CompetitiveAdvantageRatios from '../CompanyInfo/CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';

function CompanyDashboard() {
  return (
    <div>
      <div className="panels">
        <div className="panel-financialstatements">
          <h6>Company Profile</h6>
          <CompanyProfile></CompanyProfile>
           <h6>Income Statements</h6>
          <IncomeStatement></IncomeStatement>
          <h6>Balance Sheets</h6>
          <BalanceSheet></BalanceSheet>
          <h6>Cash Flow Statements</h6>
          <CashFlowStatement></CashFlowStatement>
          <h6>Competitive Advantage Ratios</h6>
          <CompetitiveAdvantageRatios></CompetitiveAdvantageRatios>
        </div>
      </div>
    </div>
  );
}

export default CompanyDashboard