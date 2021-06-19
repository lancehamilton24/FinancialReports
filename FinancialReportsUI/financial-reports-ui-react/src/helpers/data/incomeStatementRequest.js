import axios from 'axios';

 const getRequest = companyTicker => new Promise((resolve, reject) => {
   axios
     .get(`http://localhost:31583/api/financialstatments/incomestatements/${companyTicker}`)
     .then((res) => {
        const products = res.data;
       resolve(products);
     })
     .catch(err => reject(err));
 });

export default {
  getRequest,
};