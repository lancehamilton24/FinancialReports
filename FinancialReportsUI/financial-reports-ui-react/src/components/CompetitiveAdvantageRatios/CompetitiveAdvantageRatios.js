import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import CompetitiveAdvantageRatioTable from '../../helpers/statementTables/CompetitiveAdvantageRatioTable/CompetitiveAdvantageRatioTable';
import './CompetitiveAdvantageRatios.css';

export default class CompetitiveAdvantageRatios extends Component {
  constructor(props) {
  super(props);
  this.state = {ratios: []};
  }

static getDerivedStateFromProps(props, state) {
  return {ratios: props.competitiveAdvantageRatios };
}

  render() {
    const { ratios } = this.state;
    if (ratios != null)
    {
    return (
      <CompetitiveAdvantageRatioTable competitiveAdvantageRatios={ratios}></CompetitiveAdvantageRatioTable>
    );
    }
    return (
      <div class="balanceSheet">
      <Table striped bordered responsive="sm">
        <h1>Ratio Data Not Available</h1>
      </Table>
    </div>
    );
  }
}
