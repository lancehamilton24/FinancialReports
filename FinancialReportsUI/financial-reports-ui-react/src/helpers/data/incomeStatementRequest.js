import axios from 'axios';

 const getRequest = companyTicker => new Promise((resolve, reject) => {
   axios
     .get(`https://localhost:44346/api/FinancialStatements/incomestatements/${companyTicker}`)
     .then((res) => {
        const products = res.data;
       resolve(products);
     })
     .catch(err => reject(err));
 });

export default {
  getRequest,
};