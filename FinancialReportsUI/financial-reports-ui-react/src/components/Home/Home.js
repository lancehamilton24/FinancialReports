import React from 'react';
import IncomeStatement from '../IncomeStatement/IncomeStatement';
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
    this.setState({companyTicker: this.tickerInput.current.value});
    if (this.tickerInput.current.value !== null)
    {
      this.setState({isTickerSubmitted: true});
    }
};

  render() {
    if(this.state.isTickerSubmitted === false)
    {
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
        <h1>Fincancial Statement Analysis</h1>
        <form>
        <input type="text" placeholder="Enter Company Ticker" ref={this.tickerInput} required></input>
        <button type="button" onClick={this.submitHandler}>Get Data</button>
        </form>
        <IncomeStatement companyTicker={this.state.companyTicker}></IncomeStatement>
      </div>
    );
  }
}


export default Home;
