import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import BalanceSheetTable from '../BalanceSheetTable/BalanceSheetTable';
import balanceSheetRequest from '../../helpers/data/balanceSheetRequest';
import './BalanceSheet.css';

export default class BalanceSheet extends Component {
  constructor(props) {
    super(props);
    this.state = {balanceSheets: []};
  }

  static getDerivedStateFromProps(props, state) {
    return {balanceSheets: props.balanceSheets };
  }

  render() {
    const { balanceSheets } = this.state;
    if (balanceSheets != null)
    {
    return (
      <BalanceSheetTable balanceSheets={balanceSheets}></BalanceSheetTable>
    );
    }
    return (
      <div class="balanceSheet">
      <Table striped bordered responsive="sm">
        <h1>Income Statement Data Not Available</h1>
      </Table>
    </div>
    );
  }
}
