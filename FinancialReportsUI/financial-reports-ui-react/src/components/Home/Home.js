import React, { useState, useRef } from 'react';
import CompanyProfile from '../CompanyInfo/CompanyProfile/CompanyProfile';
import IncomeStatement from '../CompanyInfo/IncomeStatement/IncomeStatement';
import BalanceSheet from '../CompanyInfo/BalanceSheet/BalanceSheet';
import CashFlowStatement from '../CompanyInfo/CashFlowStatement/CashFlowStatement';
import CompetitiveAdvantageRatios from '../CompanyInfo/CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';
import incomeStatementRequest from '../../Data/financialStatementsRequest';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import NavBar from '../MaterialUI/AppBar';
import IndexCard from '../MaterialUI/IndexCard';
import './Home.css';
import 'bootstrap/dist/css/bootstrap.css';

const Home = () => {
  const [ financialStatements, setFinancialStatements ] = useState([]);

  const getAllFinancialStatements = (companyTicker) => {
    incomeStatementRequest.getAllFinancialStatements(companyTicker).then((financialStatements) => {
      setFinancialStatements(financialStatements);
    })
  }

  const tickerInput = useRef('');

  const submitTicker = () => {
    getAllFinancialStatements(tickerInput.current.value);
  };

  const newGroupSearch = (e) => {
    e.preventDefault();
    setFinancialStatements([]);
  };

  if (financialStatements.length <= 0) {
      return (
        <div className="home">
          <NavBar></NavBar>
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
  // return (
  //   <div>
  //     <NavBar></NavBar>
  //     <button type="button" onClick={newGroupSearch}>Search New Group</button>
  //     <div className="panels">
  //       <div className="panel-financialstatements">
  //         <h6>Company Profile</h6>
  //         <CompanyProfile companyProfile={financialStatements.companyProfile}></CompanyProfile>
  //         <h6>Income Statements</h6>
  //         <IncomeStatement incomeStatements={financialStatements.incomeStatement}></IncomeStatement>
  //         <h6>Balance Sheets</h6>
  //         <BalanceSheet balanceSheets={financialStatements.balanceSheet}></BalanceSheet>
  //         <h6>Cash Flow Statements</h6>
  //         <CashFlowStatement cashFlowStatements={financialStatements.cashFlowStatement}></CashFlowStatement>
  //         <h6>Competitive Advantage Ratios</h6>
  //         <CompetitiveAdvantageRatios competitiveAdvantageRatios={financialStatements.competitiveAdvantageRatios}></CompetitiveAdvantageRatios>
  //       </div>
  //     </div>
  //   </div>
  // );
};

export default Home;
