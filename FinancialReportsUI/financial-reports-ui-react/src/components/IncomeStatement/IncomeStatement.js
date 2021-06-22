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
    this.getAllIncomeStatements(this.props.companyTicker)
    // const listItems = this.state.incomeStatements.map((incomeStatement) =>
    //     <li key={incomeStatement.date}>{incomeStatement.year}</li>
    // );
    const IncomeStatement = ({ year, symbol, grossProfitRatioPercentage, netIncomeRatioPercentage, sgaRatioPercentage, rAndDRatioPercentage, depreciationRatioPercentage, interestExpenseRatioPercentage, incomeTaxExpenseRatioPercentage }) => (
      <div>
        <table>
            <tr>
              <th>Year</th>
              <th>Ticker</th>
              <th>Profit Margin</th>
              <th>Net Income Margin</th>
              <th>SGA Margin</th>
              <th>R/D Margin</th>
              <th>Depreciation Margin</th>
              <th>Interest Expense Margin</th>
              <th>Income Tax Expense Margin</th>
            </tr>
            <tr>
              <td>{year}</td>
              <td>{symbol}</td>
              <td>{grossProfitRatioPercentage}%</td>
              <td>{netIncomeRatioPercentage}%</td>
              <td>{sgaRatioPercentage}%</td>
              <td>{rAndDRatioPercentage}%</td>
              <td>{depreciationRatioPercentage}%</td>
              <td>{interestExpenseRatioPercentage}%</td>
              <td>{incomeTaxExpenseRatioPercentage}%</td>
            </tr>
        </table>
      </div>
    );

    return (
      <div className="container">
        <h4>Company Income Statements</h4>
        {this.state.incomeStatements.map((incomeStatement) => (
          <IncomeStatement
            year={incomeStatement.year}
            symbol={incomeStatement.symbol}
            grossProfitRatioPercentage={incomeStatement.grossProfitRatioPercentage}
            netIncomeRatioPercentage={incomeStatement.netIncomeRatioPercentage}
            sgaratiopercentag={incomeStatement.sgaratiopercentag}
            rAndDRatioPercentage={incomeStatement.rAndDRatioPercentage}
            depreciationRatioPercentage={incomeStatement.depreciationRatioPercentage}
            interestExpenseRatioPercentage={incomeStatement.interestExpenseRatioPercentage}
            incomeTaxExpenseRatioPercentage={incomeStatement.incomeTaxExpenseRatioPercentage}
            key={incomeStatement.id}
          />
        ))}
      </div>
    );
  }
}


export default IncomeStatement;