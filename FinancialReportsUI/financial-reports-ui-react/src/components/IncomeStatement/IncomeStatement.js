import React from 'react';
import { Table } from 'react-bootstrap';
import './IncomeStatement.css';


const IncomeStatement = (props) => {
  return (
    <div class="incomestatement">
        <Table striped bordered responsive="sm">
          <thead>
            <tr>
              <th>Year</th>
              <th>Revenue</th>
              <th>Gross Profit</th>
              <th>Net Income</th>
              <th>Operating Expense</th>
              <th>EPS</th>
              {/* <th>Profit Margin</th>
              <th>Net Income Margin</th>
              <th>Operating Expense Margin</th>
              <th>SGA Margin</th>
              <th>R/D Margin</th>
              <th>Depreciation Margin</th>
              <th>Interest Expense Margin</th> */}
            </tr>
          </thead>
          <tbody>
            {props.incomeStatements.map((incomeStatement) => {
              return (
                <tr key={incomeStatement.year}>
                  <td>{incomeStatement.year}</td>
                  <td>{incomeStatement.revenue.toLocaleString()}</td>
                  <td>{incomeStatement.grossProfit.toLocaleString()}</td>
                  <td>{incomeStatement.netIncome.toLocaleString()}</td>
                  <td>{incomeStatement.operatingExpenses.toLocaleString()}</td>
                  <td>{incomeStatement.eps.toFixed(2)}</td>
                  {/* <td>{incomeStatement.grossProfitRatioPercentage}%</td>
                  <td>{incomeStatement.netIncomeRatioPercentage}%</td>
                  <td>{incomeStatement.operatingExpenseRatio}%</td>
                  <td>{incomeStatement.sgaRatioPercentage}%</td>
                  <td>{incomeStatement.rAndDRatioPercentage}%</td>
                  <td>{incomeStatement.depreciationRatioPercentage}%</td>
                  <td>{incomeStatement.interestExpenseRatioPercentage}%</td> */}
                </tr>
              );
            })}
          </tbody>
        </Table>
      </div>
  );
};

export default IncomeStatement;