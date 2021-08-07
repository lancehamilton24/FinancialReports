import React, { Component } from 'react'
import { Table } from 'react-bootstrap';
import './CompanyProfileTable.css';

export default class CompanyProfileTable extends Component {
  render() {
    const { companyProfile } = this.props;
    return (
      <div class="profile">
        <Table striped bordered responsive="sm">
                <thead>
                    <tr>
                        <th>Ticker</th>
                        <th>Company Name</th>
                        <th>Price</th>
                        <th>Market Cap</th>
                        <th>Year Low</th>
                        <th>Year High</th>
                        <th>PE</th>
                    </tr>
                </thead>
                <tbody>
                                <td>{companyProfile.symbol}</td>
                                <td>{companyProfile.name}</td>
                                <td>{companyProfile.price.toLocaleString(2)}</td>
                                <td>{companyProfile.marketCap.toLocaleString()}</td>
                                <td>{companyProfile.yearLow.toLocaleString(2)}</td>
                                <td>{companyProfile.yearHigh.toLocaleString(2)}</td>
                                <td>{companyProfile.pe.toFixed(2)}</td>
                </tbody>
            </Table>
            </div>
    )
  }
}
