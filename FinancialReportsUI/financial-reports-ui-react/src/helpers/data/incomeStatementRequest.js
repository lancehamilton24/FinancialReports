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

export default {
  getAllIncomeStatements,
};