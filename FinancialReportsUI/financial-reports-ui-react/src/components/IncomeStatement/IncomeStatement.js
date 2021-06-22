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
    const IncomeStatement = ({ year, symbol, grossprofitratiopercentage, netincomeratiopercentage, sgaratiopercentage, randdatiopercentage, depreciationratiopercentage, interestexpenseratiopercentage, incometaxexpenseratiopercentage }) => (
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
              <td>{grossprofitratiopercentage}%</td>
              <td>{netincomeratiopercentage}%</td>
              <td>{sgaratiopercentage}%</td>
              <td>{randdatiopercentage}%</td>
              <td>{depreciationratiopercentage}%</td>
              <td>{interestexpenseratiopercentage}%</td>
              <td>{incometaxexpenseratiopercentage}%</td>
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
            grossprofitratiopercentage={incomeStatement.grossprofitratiopercentage}
            netincomeratiopercentage={incomeStatement.netincomeratiopercentage}
            sgaratiopercentag={incomeStatement.sgaratiopercentag}
            randdatiopercentage={incomeStatement.randdatiopercentage}
            depreciationratiopercentage={incomeStatement.depreciationratiopercentage}
            interestexpenseratiopercentage={incomeStatement.interestexpenseratiopercentage}
            incometaxexpenseratiopercentage={incomeStatement.incometaxexpenseratiopercentage}
            key={incomeStatement.id}
          />
        ))}
      </div>
    );
  }
}


export default IncomeStatement;