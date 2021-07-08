import React from 'react';
import { Table } from 'react-bootstrap';
import companyProfileRequests from '../../helpers/data/companyProfileRequest';
import './CompanyProfile.css';

export class CompanyProfile extends React.Component {
  state = {
    companyProfile: []
  }

  componentDidUpdate() {
    this.getCompanyProfile(this.props.companyTicker)
  }

  componentDidMount(){
    this.getCompanyProfile(this.props.companyTicker)
  }

  getCompanyProfile = (companyTicker) => {
    companyProfileRequests.getProfileRequest(companyTicker).then((companyProfile) => {
      this.setState({ companyProfile });
    })
  }
  render() {
    const { companyProfile } = this.state;
    return (
      <div className="container">
        <h4>Company Profile</h4>
        <div class="profile">
        <Table striped bordered responsive="sm">
                <thead>
                    <tr>
                        <th>Ticker</th>
                        <th>Company Name</th>
                        <th>Price</th>
                        <th>Market Cap</th>
                    </tr>
                </thead>
                <tbody>
                {companyProfile.map((companyProfile) => {
                        return (
                            <tr key={companyProfile.symbol}>
                                <td>{companyProfile.symbol}</td>
                                <td>{companyProfile.companyName}</td>
                                <td>{companyProfile.price.toLocaleString()}</td>
                                <td>{companyProfile.mktCap.toLocaleString()}</td>
                            </tr>
                        );
                    })}
                </tbody>
            </Table>
            </div>
      </div>
    );
  }
}

export default CompanyProfile
