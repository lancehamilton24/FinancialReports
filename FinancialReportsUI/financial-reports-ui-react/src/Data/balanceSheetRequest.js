import axios from 'axios';

 const getAllBalanceSheets = companyTicker => new Promise((resolve, reject) => {
   axios
     .get(`https://localhost:44346/api/FinancialStatements/balancesheets/${companyTicker}`)
     .then((res) => {
        const balanceSheets = res.data;
       resolve(balanceSheets);
     })
     .catch(err => reject(err));
 });

export default {
  getAllBalanceSheets,
};