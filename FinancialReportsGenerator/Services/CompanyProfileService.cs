using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Interfaces;
using FinancialReportsGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class CompanyProfileService
    {
        IFMPApiClient _apiClient;

        public CompanyProfileService(IFMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        {
            var profileResponse = await _apiClient.GetCompanyProfile(companyTicker);
            CompanyProfile companyProfile = new CompanyProfile();

            if (profileResponse.Item1 == System.Net.HttpStatusCode.OK)
            {
                var profileJSON = profileResponse.Item2;
                foreach (var profile in profileJSON)
                {
                    companyProfile.Symbol = profile.Symbol;
                    companyProfile.Name = profile.CompanyName;
                    companyProfile.Price = profile.Price;
                    companyProfile.MarketCap = profile.MktCap;
                }
            }
            
            return companyProfile;
        }
    }
}
