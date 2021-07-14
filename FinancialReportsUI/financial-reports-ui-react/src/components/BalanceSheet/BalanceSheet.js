import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import balanceSheetRequest from '../../helpers/data/balanceSheetRequest';
import './BalanceSheet.css';

export default class BalanceSheet extends Component {
  state = {
    balanceSheets: []
  }

  componentDidUpdate() {
    this.getAllBalanceSheets(this.props.companyTicker)
  }

  componentDidMount() {
    this.getAllBalanceSheets(this.props.companyTicker)
  }

  getAllBalanceSheets = (companyTicker) => {
    balanceSheetRequest.getAllBalanceSheets(companyTicker).then((balanceSheets) => {
      this.setState({ balanceSheets });
    })
  }

  render() {
    const { balanceSheets } = this.state;
    return (
        <div class="balancesheet">
          {/* <Table striped bordered responsive="sm">
            <thead>
              <tr>
                <th>Year</th>
                <th>Revenue</th>
                <th>Gross Profit</th>
                <th>Profit Margin</th>
                <th>Net Income</th>
                <th>Net Income Margin</th>
                <th>Operating Expense</th>
                <th>SGA Margin</th>
                <th>R/D Margin</th>
                <th>Depreciation Margin</th>
                <th>Interest Expense Margin</th>
                <th>EPS</th>
              </tr>
            </thead>
            <tbody>
              {balanceSheets.map((balanceSheet) => {
                return (
                  <tr key={incomeStatement.year}>
                    <td>{incomeStatement.year}</td>
                  </tr>
                );
              })}
            </tbody>
          </Table> */}
        </div>
    );
  }
}
