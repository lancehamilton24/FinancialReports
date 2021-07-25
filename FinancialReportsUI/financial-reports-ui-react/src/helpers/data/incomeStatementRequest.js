import axios from 'axios';

 const getAllIncomeStatements = companyTicker => new Promise((resolve, reject) => {
   axios
     .get(`https://localhost:44346/api/FinancialStatements/incomestatements/${companyTicker}`)
     .then((res) => {
        const incomeStatements = res.data;
       resolve(incomeStatements);
     })
     .catch(err => reject(err));
 });

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
  getAllIncomeStatements,
  getAllFinancialStatements,
};