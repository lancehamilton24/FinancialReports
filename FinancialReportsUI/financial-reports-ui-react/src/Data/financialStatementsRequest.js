import axios from 'axios';

 const getAllFinancialStatements = companyTicker => new Promise((resolve, reject) => {
  axios
    .get(`https://localhost:44346/api/FinancialStatements/financialstatements/${companyTicker}`)
    .then((res) => {
       const financialStatements = res.data;
      resolve(financialStatements);
    })
    .catch(err => reject(err));
});

export default {
  getAllFinancialStatements,
};