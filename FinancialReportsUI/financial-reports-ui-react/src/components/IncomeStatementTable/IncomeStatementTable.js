import React, { Component } from 'react';
import { Table } from 'react-bootstrap';

export default class IncomeStatementTable extends Component {

  render() {
    return (
      <div class="incomestatement">
          <Table striped bordered responsive="sm">
            <thead>
              <tr>
                <th>Year</th>
                <th>Revenue</th>
                <th>Gross Profit</th>
                <th>Profit Margin</th>
                <th>Net Income</th>
                <th>Net Income Margin</th>
                <th>Operating Expense</th>
                <th>Operating Expense Margin</th>
                <th>SGA Margin</th>
                <th>R/D Margin</th>
                <th>Depreciation Margin</th>
                <th>Interest Expense Margin</th>
                <th>EPS</th>
              </tr>
            </thead>
            <tbody>
              {this.props.incomeStatements.map((incomeStatement) => {
                return (
                  <tr key={incomeStatement.year}>
                    <td>{incomeStatement.year}</td>
                    <td>{incomeStatement.revenue.toLocaleString()}</td>
                    <td>{incomeStatement.grossProfit.toLocaleString()}</td>
                    <td>{incomeStatement.grossProfitRatioPercentage}%</td>
                    <td>{incomeStatement.netIncome.toLocaleString()}</td>
                    <td>{incomeStatement.netIncomeRatioPercentage}%</td>
                    <td>{incomeStatement.operatingExpenses.toLocaleString()}</td>
                    <td>{incomeStatement.operatingExpenseRatio}%</td>
                    <td>{incomeStatement.sgaRatioPercentage}%</td>
                    <td>{incomeStatement.rAndDRatioPercentage}%</td>
                    <td>{incomeStatement.depreciationRatioPercentage}%</td>
                    <td>{incomeStatement.interestExpenseRatioPercentage}%</td>
                    <td>{incomeStatement.eps.toFixed(2)}</td>
                  </tr>
                );
              })}
            </tbody>
          </Table>
        </div>
    )
  }
}
