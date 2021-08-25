import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import CashFlowStatementTable from '../../helpers/statementTables/CashFlowStatementTable/CashFlowStatementTable';
import './CashFlowStatement.css';

export default class CashFlowStatement extends Component {
  constructor(props) {
    super(props);
    this.state = {cashFlowStatements : []};
  }

  static getDerivedStateFromProps(props, state) {
    return {cashFlowStatements: props.cashFlowStatements };
  }

  render() {
    const { cashFlowStatements } = this.state;
    if (cashFlowStatements != null)
    {
    return (
      <CashFlowStatementTable cashFlowStatements={cashFlowStatements}></CashFlowStatementTable>
    );
    }
    return (
      <div class="cashFlowStatement">
      <Table striped bordered responsive="sm">
        <h1>Cash Flow Data Not Available</h1>
      </Table>
    </div>
    );
  }
}
