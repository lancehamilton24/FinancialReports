import React from 'react';
import { Table } from 'react-bootstrap';
import CompanyProfileTable from '../../helpers/statementTables/CompanyProfileTable/CompanyProfileTable';
import './CompanyProfile.css';

export class CompanyProfile extends React.Component {
  constructor(props) {
    super(props);
    this.state = {companyProfile: []};
  }

  static getDerivedStateFromProps(props, state) {
    return {companyProfile: props.companyProfile };
  }

  render() {
    const { companyProfile } = this.state;
    if (companyProfile != null)
    {
      return(
        <CompanyProfileTable companyProfile={companyProfile}></CompanyProfileTable>
      );
    }
    else
    {
      return (
        <div className="profile">
          <Table striped bordered responsive="sm">
        <h1>Company Profile Data Not Available</h1>
      </Table>
        </div>
      );
    }
  }
}

export default CompanyProfile
