import React from 'react';
import incomeStatementRequests from '../../helpers/data/incomeStatementRequest';
import './IncomeStatement.css';

class IncomeStatement extends React.Component {

  state = {
    incomeStatements: []
  }

  componentDidMount() {
    // this.getAllIncomeStatements();
  }

  getAllIncomeStatements = (companyTicker) => {
    incomeStatementRequests.getRequest(companyTicker).then((incomeStatements) => {
      this.setState({ incomeStatements });
    })
  }

  render() {
    // this.getAllIncomeStatements(this.props.companyTicker)
    return (
      <div className="container">
      </div>
    );
  }
}


export default IncomeStatement;