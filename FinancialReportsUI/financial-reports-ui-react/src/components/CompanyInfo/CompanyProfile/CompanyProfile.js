import React, {useContext} from 'react';
import { FinancialStatementsContext } from '../../../contexts/FinancialStatementsContext';
import { Table } from 'react-bootstrap';
import './CompanyProfile.css';

const CompanyProfile = () => {
  const {financialStatements} = useContext(FinancialStatementsContext);

    if (financialStatements.companyProfile != null)
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
                                  <td>{financialStatements.companyProfile.symbol}</td>
                                  <td>{financialStatements.companyProfile.name}</td>
                                  <td>{financialStatements.companyProfile.price.toLocaleString(2)}</td>
                                  <td>{financialStatements.companyProfile.marketCap.toLocaleString()}</td>
                                  <td>{financialStatements.companyProfile.yearLow.toLocaleString(2)}</td>
                                  <td>{financialStatements.companyProfile.yearHigh.toLocaleString(2)}</td>
                                  <td>{financialStatements.companyProfile.pe.toFixed(2)}</td>
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
