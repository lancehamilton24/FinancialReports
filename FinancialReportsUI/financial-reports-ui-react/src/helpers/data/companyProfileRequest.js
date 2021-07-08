import axios from 'axios';

 const getProfileRequest = companyTicker => new Promise((resolve, reject) => {
   axios
     .get(`https://localhost:44346/api/CompanyProfile/companyprofile/${companyTicker}`)
     .then((res) => {
        const products = res.data;
       resolve(products);
     })
     .catch(err => reject(err));
 });

export default {
  getProfileRequest,
};