import React, { useState, useRef, useContext } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import incomeStatementRequest from '../../Data/financialStatementsRequest';
// import CompanyProfile from '../CompanyInfo/CompanyProfile/CompanyProfile';
// import IncomeStatement from '../CompanyInfo/IncomeStatement/IncomeStatement';
// import BalanceSheet from '../CompanyInfo/BalanceSheet/BalanceSheet';
// import CashFlowStatement from '../CompanyInfo/CashFlowStatement/CashFlowStatement';
// import CompetitiveAdvantageRatios from '../CompanyInfo/CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import IndexCard from '../MaterialUI/IndexCard';
import { FinancialStatementsContext } from '../../contexts/FinancialStatementsContext';
import './Home.css';
import 'bootstrap/dist/css/bootstrap.css';

const Home = () => {
  const {financialStatements, setFinancialStatements} = useContext(FinancialStatementsContext);
  const navigate = useNavigate();
  const tickerInput = useRef('');

   const submitTicker = () => {
    getAllFinancialStatements(tickerInput.current.value);
      navigate('/companyDashboard');

  };

  const getAllFinancialStatements = (companyTicker) => {
    incomeStatementRequest.getAllFinancialStatements(companyTicker).then((financialStatements) => {
      setFinancialStatements(financialStatements);
    })
  }

  const newGroupSearch = (e) => {
    e.preventDefault();
  };

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
      )
};

export default Home;
