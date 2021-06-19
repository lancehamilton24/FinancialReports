import React from 'react';
import './IncomeStatement.css';

class IncomeStatement extends React.Component {

  state = {
    incomeStatements: []
  }

  componentDidMount() {
    this.getAllIncomeStatements();
  }

  getAllIncomeStatements = (companyTicker) => {
    //let companyTicker = Find out how to pass the company ticker here
    incomeStatementRequests.getRequest(companyTicker).then((incomeStatements) => {
      this.setState({ incomeStatements });
    })
  }

  render() {

    return (
      <div className="container">
      </div>
    );
  }
}


export default IncomeStatement;