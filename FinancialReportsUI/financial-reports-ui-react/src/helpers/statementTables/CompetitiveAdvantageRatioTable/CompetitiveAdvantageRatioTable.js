import React, { Component } from 'react';
import { Table } from 'react-bootstrap';
import './CompetitiveAdvantageRatioTable.css';

export default class CompetitiveAdvantageRatioTable extends Component {
  render() {
    return (
      <div class="competitiveAdvantageRatios">
          <Table striped bordered responsive="sm">
            <thead>
              <tr>
                <th>Year</th>
                <th>Profit Margin</th>
                <th>Net Income Margin</th>
                <th>SGA Maargin</th>
                <th>Research/Development Margin</th>
                <th>Depreciation Margin</th>
                <th>Interest Expense Margin</th>
                <th>Income Tax Expense Margin</th>
                <th>Operating Expense Margin</th>
                <th>Current Assets To Liabilities Margin</th>
                <th>Debt To Shareholders Equity Ratio</th>
                <th>CapEx Margin</th>
                <th>Net Receivables Margin</th>
                <th>Return On Assets Margin</th>
                <th>Return On Shareholders Equity Margin</th>
              </tr>
            </thead>
            <tbody>
              {this.props.competitiveAdvantageRatios.map((ratio) => {
                return (
                  <tr key={ratio.year}>
                    <td>{ratio.year}</td>
                    <td>{ratio.grossProfitMargin}%</td>
                    <td>{ratio.netIncomeMargin}%</td>
                    <td>{ratio.sgaMargin}%</td>
                    <td>{ratio.rAndDMargin}%</td>
                    <td>{ratio.depreciationMargin}%</td>
                    <td>{ratio.interestExpenseMargin}%</td>
                    <td>{ratio.incomeTaxExpenseMargin}%</td>
                    <td>{ratio.operatingExpenseMargin}%</td>
                    <td>{ratio.currAssetsToLiabilitiesMargin}%</td>
                    <td>{ratio.debtToShareholdersEquityRatio}%</td>
                    <td>{ratio.capExMargin}%</td>
                    <td>{ratio.netReceivablesMargin}%</td>
                    <td>{ratio.returnOnAssetsMargin}%</td>
                    <td>{ratio.returnOnShareholdersEquityMargin}%</td>
                  </tr>
                );
              })}
            </tbody>
          </Table>
        </div>
    )
  }
}
