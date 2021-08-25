import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import './CashFlowStatementTable.css';

export default class CashFlowStatementTable extends Component {
  render() {
    return (
      <div class="cashFlowStatement">
          <Table striped bordered responsive="sm">
            <thead>
              <tr>
                <th>Year</th>
                <th>Net Income</th>
                <th>Depreciation And Amortization</th>
                <th>Deferred Income Tax</th>
                <th>Stock Based Compensation</th>
                <th>Net Cash Provided By Operating Activities</th>
                <th>Acquisitions Net</th>
                <th>Net Cash Used For Investing Activities</th>
                <th>Debt Repayment</th>
                <th>Common Stock Issued</th>
                <th>Common Stock Repurchased</th>
                <th>Dividends Paid</th>
                <th>Net Cash Used Provided By Financing Activites</th>
                <th>Cash At Beginning Of Year</th>
                <th>Cash At The End Of Year</th>
                <th>Operating Cash Flow</th>
                <th>Capital Expenditure</th>
                <th>Free Cash Flow</th>
                <th>Capital Expenditure to Net Income Ratio</th>
              </tr>
            </thead>
            <tbody>
              {this.props.cashFlowStatements.map((cashFlowStatement) => {
                return (
                  <tr key={cashFlowStatement.year}>
                    <td>{cashFlowStatement.year}</td>
                    <td>{cashFlowStatement.netIncome.toLocaleString()}</td>
                    <td>{cashFlowStatement.depreciationAndAmortization.toLocaleString()}</td>
                    <td>{cashFlowStatement.deferredIncomeTax.toLocaleString()}</td>
                    <td>{cashFlowStatement.stockBasedCompensation.toLocaleString()}</td>
                    <td>{cashFlowStatement.netCashProvidedByOperatingActivities.toLocaleString()}</td>
                    <td>{cashFlowStatement.acquisitionsNet.toLocaleString()}</td>
                    <td>{cashFlowStatement.netCashUsedForInvestingActivites.toLocaleString()}</td>
                    <td>{cashFlowStatement.debtRepayment.toLocaleString()}</td>
                    <td>{cashFlowStatement.commonStockIssued.toLocaleString()}</td>
                    <td>{cashFlowStatement.commonStockRepurchased.toLocaleString()}</td>
                    <td>{cashFlowStatement.dividendsPaid.toLocaleString()}</td>
                    <td>{cashFlowStatement.netCashUsedProvidedByFinancingActivities.toLocaleString()}</td>
                    <td>{cashFlowStatement.cashAtBeginningOfPeriod.toLocaleString()}</td>
                    <td>{cashFlowStatement.cashAtEndOfPeriod.toLocaleString()}</td>
                    <td>{cashFlowStatement.operatingCashFlow.toLocaleString()}</td>
                    <td>{cashFlowStatement.capitalExpenditure.toLocaleString()}</td>
                    <td>{cashFlowStatement.freeCashFlow.toLocaleString()}</td>
                    <td>{cashFlowStatement.capExMargin.toFixed(2)}%</td>
                  </tr>
                );
              })}
            </tbody>
          </Table>
        </div>
    )
  }
}
