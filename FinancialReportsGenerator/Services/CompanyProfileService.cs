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
            var response = await _apiClient.GetCompanyProfile(companyTicker);
            var profiles = response.Item3;
            var companyProfile = new CompanyProfile();
            foreach (var profile in profiles)
            {
                companyProfile = new CompanyProfile
                {
                    Symbol = profile.Symbol,
                    Name = profile.Name,
                    Price = profile.Price,
                    YearHigh = profile.YearHigh,
                    YearLow = profile.YearLow,
                    MarketCap = profile.MarketCap,
                    Eps = profile.Eps,
                    Pe = profile.Pe
                };
            }

            return companyProfile;
        }
    }
}
