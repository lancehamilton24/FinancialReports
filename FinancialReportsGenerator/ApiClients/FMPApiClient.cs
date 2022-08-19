using FinancialReportsGenerator.Interfaces;
using FinancialReportsGenerator.JsonModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.ApiClients
{
    public class FMPApiClient : IFMPApiClient
    {
        private static HttpClient _httpClient;
        public FMPApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Tuple<HttpStatusCode, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/profile/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new Tuple<HttpStatusCode, List<CompanyProfileJson>>(response.StatusCode, null);
            }

            var companyProfileJSON = response.Content.ReadAsStringAsync().Result;
            List<CompanyProfileJson> companyProfile = JsonConvert.DeserializeObject<List<CompanyProfileJson>>(companyProfileJSON);
            return new Tuple<HttpStatusCode, List<CompanyProfileJson>>(response.StatusCode, companyProfile);
        }

        public async Task<Tuple<HttpStatusCode, List<IncomeStatementJson>>> IncomeStatementsGet(string companyTicker)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/income-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new Tuple<HttpStatusCode, List<IncomeStatementJson>>(response.StatusCode, null);
            }

            var incomeStatementJSON = await response.Content.ReadAsStringAsync();
            List<IncomeStatementJson> incomeStatements = JsonConvert.DeserializeObject<List<IncomeStatementJson>>(incomeStatementJSON);
            return new Tuple<HttpStatusCode, List<IncomeStatementJson>>(response.StatusCode, incomeStatements);
        }

        public async Task<Tuple<HttpStatusCode, List<BalanceSheetJson>>> BalanceSheetsGet(string companyTicker)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/balance-sheet-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new Tuple<HttpStatusCode, List<BalanceSheetJson>>(response.StatusCode, null);
            }

            var balanceSheetJSON = await response.Content.ReadAsStringAsync();
            List<BalanceSheetJson> balanceSheets = JsonConvert.DeserializeObject<List<BalanceSheetJson>>(balanceSheetJSON);
            return new Tuple<HttpStatusCode,  List<BalanceSheetJson>>(HttpStatusCode.OK, balanceSheets);

        }

        public async Task<Tuple<HttpStatusCode, List<CashFlowStatementJson>>> CashFlowStatementsGet(string companyTicker)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/cash-flow-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new Tuple<HttpStatusCode, List<CashFlowStatementJson>>(response.StatusCode, null);
            }

            var cashFlowStatmentJSON = await response.Content.ReadAsStringAsync();
            List<CashFlowStatementJson> cashFlowStatements = JsonConvert.DeserializeObject<List<CashFlowStatementJson>>(cashFlowStatmentJSON);
            return new Tuple<HttpStatusCode, List<CashFlowStatementJson>>(HttpStatusCode.OK, cashFlowStatements);
        }
    }
}
