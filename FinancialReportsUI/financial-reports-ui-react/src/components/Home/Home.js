import React from 'react';
import CompanyProfile from '../CompanyProfile/CompanyProfile';
import IncomeStatement from '../IncomeStatement/IncomeStatement';
import BalanceSheet from '../BalanceSheet/BalanceSheet';
import CashFlowStatement from '../CashFlowStatement/CashFlowStatement';
import 'bootstrap/dist/css/bootstrap.css';
import incomeStatementRequest from '../../Data/incomeStatementRequest';
import './Home.css';
import CompetitiveAdvantageRatios from '../CompetitiveAdvantageRatios/CompetitiveAdvantageRatios';

class Home extends React.Component {
  constructor(props) {
    super(props);
    this.state = 
    {
      isTickerSubmitted: false,
      financialStatements: []
    };
  }

  getAllFinancialStatements = (companyTicker) => {
    incomeStatementRequest.getAllFinancialStatements(companyTicker).then((financialStatements) => {
      this.setState({ financialStatements });
    })
  }

  tickerInput = React.createRef();

  submitHandler = (e) => {
    e.preventDefault();
    if (this.tickerInput.current.value !== null) {
      this.getAllFinancialStatements(this.tickerInput.current.value);
      this.setState({ isTickerSubmitted: true });
    } 
  };

  newGroupSearch = (e) => {
    e.preventDefault();
    this.setState({ financialStatements: [] });
  };

  render() {
    const { financialStatements } = this.state;
    if (this.state.financialStatements.length <= 0) {
      return (
        <div>
          <h1>Fincancial Statement Analysis</h1>
          <form>
            <input type="text" placeholder="Enter Company Ticker" ref={this.tickerInput} required></input>
            <button type="button" onClick={this.submitHandler}>Get Data</button>
          </form>
        </div>
      );
    }
    return (
      <div>
        <button type="button" onClick={this.newGroupSearch}>Search New Group</button>
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
  }
}


export default Home;
