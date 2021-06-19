import React from 'react';
import IncomeStatement from '../IncomeStatement/IncomeStatement';
import './Home.css';

class Home extends React.Component {

  state = {
    companyTicker: ''
  }

  componentDidMount() {

  }

  submitCompanyTicker = () => {
    console.log(this.state);
  }

  inputSubmitHandler = (e) => {
    e.preventDefault();
    this.setState({
        companyTicker: e.target.value
    })
}

  render() {
    // onChange={this.inputSubmitHandler}
    return (
      <div className="container">
        <h1>Fincancial Statement Analysis</h1>
        <form>
        <input className="form-control form-control-lg" type="text" placeholder="Enter Company Ticker" onChange={this.inputSubmitHandler}></input>
        <button type="button" className="btn btn-dark" onClick={this.submitCompanyTicker}>Get Data</button>
        </form>
        <IncomeStatement companyTicker={this.state.companyTicker}></IncomeStatement>
      </div>
    );
  }
}


export default Home;
