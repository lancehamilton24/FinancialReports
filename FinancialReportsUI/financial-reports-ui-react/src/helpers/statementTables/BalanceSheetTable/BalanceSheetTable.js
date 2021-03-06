import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import './BalanceSheetTable.css';

export default class BalanceSheetTable extends Component {

  render() {
    return (
      <div class="balancesheet">
          <Table striped bordered responsive="sm">
            <thead>
              <tr>
                <th>Year</th>
                <th>Cash/Equivalents</th>
                <th>Inventory</th>
                <th>Net Recievables</th>
                <th>Property/Plant/Equipment</th>
                <th>Goodwill</th>
                <th>Intangible Assets</th>
                <th>Long-Term Investments</th>
                <th>Short-Term Debt</th>
                <th>Long-Term Debt</th>
                <th>Total Assets</th>
                <th>Total Liabilities</th>
                <th>Net Worth/Shareholders' Equity</th>
                <th>Retained Earnings</th>
                {/* <th>Net Receivables Ratio</th>
                <th>Curr Assets to Liabilities Ratio</th>
                <th>Debt To Shareholders' Equity Ratio</th>
                <th>Return on Assets Ratio</th>
                <th>Return on Shareholders' Equity Ratio</th> */}
              </tr>
            </thead>
            <tbody>
              {this.props.balanceSheets.map((balanceSheet) => {
                return (
                  <tr key={balanceSheet.year}>
                    <td>{balanceSheet.year}</td>
                    <td>{balanceSheet.cashAndCashEquivalents.toLocaleString()}</td>
                    <td>{balanceSheet.inventory.toLocaleString()}</td>
                    <td>{balanceSheet.netReceivables.toLocaleString()}</td>
                    <td>{balanceSheet.propertyPlantEquipmentNet.toLocaleString()}</td>
                    <td>{balanceSheet.goodwill.toLocaleString()}</td>
                    <td>{balanceSheet.intangibleAssets.toLocaleString()}</td>
                    <td>{balanceSheet.longTermInvestments.toLocaleString()}</td>
                    <td>{balanceSheet.shortTermDebt.toLocaleString()}</td>
                    <td>{balanceSheet.longTermDebt.toLocaleString()}</td>
                    <td>{balanceSheet.totalAssets.toLocaleString()}</td>
                    <td>{balanceSheet.totalLiabilities.toLocaleString()}</td>
                    <td>{balanceSheet.totalStockholdersEquity.toLocaleString()}</td>
                    <td>{balanceSheet.retainedEarnings.toLocaleString()}</td>
                    {/* <td>{balanceSheet.netReceivablesRatio.toFixed(2)}%</td>
                    <td>{balanceSheet.currAssetsToLiabilitiesRatio}%</td>
                    <td>{balanceSheet.debtToShareholdersEquityRatio.toFixed(2)}%</td>
                    <td>{balanceSheet.returnOnAssetsRatio}%</td>
                    <td>{balanceSheet.returnOnShareholdersEquityRatio}%</td> */}
                  </tr>
                );
              })}
            </tbody>
          </Table>
        </div>
    )
  }
}
