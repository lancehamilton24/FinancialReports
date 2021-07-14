import React from 'react';
import CompanyProfile from '../CompanyProfile/CompanyProfile';
import IncomeStatement from '../IncomeStatement/IncomeStatement';
import BalanceSheet from '../BalanceSheet/BalanceSheet';
import 'bootstrap/dist/css/bootstrap.css';
import './Home.css';

class Home extends React.Component {

  state = {
    companyTicker: '',
    isTickerSubmitted: false,
  }

  componentDidMount() {

  }

  tickerInput = React.createRef();

  submitHandler = (e) => {
    e.preventDefault();
    this.setState({ companyTicker: this.tickerInput.current.value });
    if (this.tickerInput.current.value !== null) {
      this.setState({ isTickerSubmitted: true });
    }
  };

  newGroupSearch = (e) => {
    e.preventDefault();
    this.setState({ companyTicker: '' });
    this.setState({ isTickerSubmitted: false });
  };

  render() {
    const { companyTicker } = this.state;
    if (this.state.isTickerSubmitted === false) {
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
          <div className="panel-companyprofile">
            <CompanyProfile companyTicker={companyTicker}></CompanyProfile>
          </div>
          <div className="panel-financialstatements">
            <h6>Income Statements</h6>
            <IncomeStatement companyTicker={companyTicker}></IncomeStatement>
            <h6>Balance Sheets</h6>
            <BalanceSheet companyTicker={companyTicker}></BalanceSheet>
          </div>
        </div>
      </div>
    );
  }
}


export default Home;
