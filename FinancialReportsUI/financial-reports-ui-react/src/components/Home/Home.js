import React, { useState, useRef, useContext } from 'react';
import CompanyProfile from '../CompanyInfo/CompanyProfile/CompanyProfile';
import IncomeStatement from '../CompanyInfo/IncomeStatement/IncomeStatement';
import BalanceSheet from '../CompanyInfo/BalanceSheet/BalanceSheet';
import CashFlowStatement from '../CompanyInfo/CashFlowStatement/CashFlowStatement';
import CompetitiveAdvantageRatios from '../CompanyInfo/CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import IndexCard from '../MaterialUI/IndexCard';
import { FinancialStatementsContext } from '../../contexts/FinancialStatementsContext';
import './Home.css';
import 'bootstrap/dist/css/bootstrap.css';

const Home = () => {
  const {financialStatements, getAllFinancialStatements, clearFinancialStatements} = useContext(FinancialStatementsContext);

  const tickerInput = useRef('');

   const submitTicker = () => {
    getAllFinancialStatements(tickerInput.current.value);
  };

  const newGroupSearch = (e) => {
    e.preventDefault();
    clearFinancialStatements();
  };

  if (financialStatements.length <= 0) {
      return (
        <div className="home">
          <div className="companySearch">
            <TextField id="filled-basic" label="Enter Company Ticker" variant="filled" inputRef={tickerInput}/>
            <Button variant="contained" onClick={submitTicker}>Search</Button>
          </div>
          <div className="indexInfo">
          <IndexCard variant="outlined"></IndexCard>
          </div>
        </div>
      );
  }
  return (
    <div>
      <button type="button" onClick={newGroupSearch}>Search New Group</button>
      <div className="panels">
        <div className="panel-financialstatements">
          <h6>Company Profile</h6>
          <CompanyProfile companyProfile={financialStatements.companyProfile}></CompanyProfile>
          <h6>Income Statements</h6>
          <IncomeStatement incomeStatements={financialStatements.incomeStatement}></IncomeStatement>
          <h6>Balance Sheets</h6>
          <BalanceSheet balanceSheets={financialStatements.balanceSheet}></BalanceSheet>
          <h6>Cash Flow Statements</h6>
          <CashFlowStatement cashFlowStatements={financialStatements.cashFlowStatement}></CashFlowStatement>
          <h6>Competitive Advantage Ratios</h6>
          <CompetitiveAdvantageRatios competitiveAdvantageRatios={financialStatements.competitiveAdvantageRatios}></CompetitiveAdvantageRatios>
        </div>
      </div>
    </div>
  );
};

export default Home;
