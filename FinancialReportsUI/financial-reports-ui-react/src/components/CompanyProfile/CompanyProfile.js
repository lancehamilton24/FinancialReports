import React from 'react';
import { Table } from 'react-bootstrap';
import './CompanyProfile.css';

const CompanyProfile = (props) => {
    if (props.companyProfile != null)
    {
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
                                  <td>{props.companyProfile.symbol}</td>
                                  <td>{props.companyProfile.name}</td>
                                  <td>{props.companyProfile.price.toLocaleString(2)}</td>
                                  <td>{props.companyProfile.marketCap.toLocaleString()}</td>
                                  <td>{props.companyProfile.yearLow.toLocaleString(2)}</td>
                                  <td>{props.companyProfile.yearHigh.toLocaleString(2)}</td>
                                  <td>{props.companyProfile.pe.toFixed(2)}</td>
                  </tbody>
              </Table>
              </div>
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
};

export default CompanyProfile;

// export class CompanyProfile extends React.Component {
//   constructor(props) {
//     super(props);
//     this.state = {companyProfile: []};
//   }

//   static getDerivedStateFromProps(props, state) {
//     return {companyProfile: props.companyProfile };
//   }

//   render() {
//     const { companyProfile } = this.state;
//     if (companyProfile != null)
//     {
//       return(
//         <CompanyProfileTable companyProfile={companyProfile}></CompanyProfileTable>
//       );
//     }
//     else
//     {
//       return (
//         <div className="profile">
//           <Table striped bordered responsive="sm">
//         <h1>Company Profile Data Not Available</h1>
//       </Table>
//         </div>
//       );
//     }
//   }
// }

// export default CompanyProfile
