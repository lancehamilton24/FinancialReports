import React from 'react';
import { Table } from 'react-bootstrap';
import incomeStatementRequests from '../../helpers/data/incomeStatementRequest';
import './IncomeStatement.css';

class IncomeStatement extends React.Component {

  state = {
    incomeStatements: []
  }

  componentDidUpdate() {
    this.getAllIncomeStatements(this.props.companyTicker)
  }

  componentDidMount(){
    this.getAllIncomeStatements(this.props.companyTicker)
  }

  getAllIncomeStatements = (companyTicker) => {
    incomeStatementRequests.getRequest(companyTicker).then((incomeStatements) => {
      this.setState({ incomeStatements });
    })
  }

  render() {
    const { incomeStatements } = this.state;
    return (
      <div className="container">
        <div class="incomestatement">
        <h4>{this.props.companyTicker} Income Statements</h4>
        <Table striped bordered responsive="sm">
                <thead>
                    <tr>
                        <th>Year</th>
                        {/* <td>Ticker</td> */}
                        <th>Profit Margin</th>
                        <th>Net Income Margin</th>
                        <th>SGA Margin</th>
                        <th>R/D Margin</th>
                        <th>Depreciation Margin</th>
                        <th>Interest Expense Margin</th>
                        <th>Income Tax Expense Margin</th>
                        <th>EPS</th>
                    </tr>
                </thead>
                <tbody>
                    {incomeStatements.map((incomeStatement) => {
                        return (
                            <tr key={incomeStatement.year}>
                                <td>{incomeStatement.year}</td>
                                <td>{incomeStatement.grossProfitRatioPercentage}%</td>
                                <td>{incomeStatement.netIncomeRatioPercentage}%</td>
                                <td>{incomeStatement.sgaRatioPercentage}%</td>
                                <td>{incomeStatement.rAndDRatioPercentage}%</td>
                                <td>{incomeStatement.depreciationRatioPercentage}%</td>
                                <td>{incomeStatement.interestExpenseRatioPercentage}%</td>
                                <td>{incomeStatement.incomeTaxExpenseRatioPercentage}%</td>
                                <td>{incomeStatement.eps}</td>
                            </tr>
                        );
                    })}
                </tbody>
            </Table>
            </div>
      </div>
    );
  }
}


export default IncomeStatement;