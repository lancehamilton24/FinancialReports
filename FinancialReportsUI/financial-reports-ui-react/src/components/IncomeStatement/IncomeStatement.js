import React from 'react';
import { Table } from 'react-bootstrap';
import IncomeStatementTable from '../IncomeStatementTable/IncomeStatementTable';
import incomeStatementRequest from '../../helpers/data/incomeStatementRequest';
import './IncomeStatement.css';

class IncomeStatement extends React.Component {
  constructor(props) {
    super(props);
    this.state = {incomeStatements: []};
  }

  static getDerivedStateFromProps(props, state) {
    return {incomeStatements: props.incomeStatements };
  }

  render() {
    const { incomeStatements } = this.state;
    if (incomeStatements != null)
    {
    return (
      <IncomeStatementTable incomeStatements={incomeStatements}></IncomeStatementTable>
    );
    }
    return (
      <div class="incomestatement">
        <Table striped bordered responsive="sm">
          <h1>Income Statement Data Not Available</h1>
        </Table>
      </div>
  );
  }
}


export default IncomeStatement;