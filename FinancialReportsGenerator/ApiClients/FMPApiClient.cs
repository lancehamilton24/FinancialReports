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
    public class FMPApiClient
    {
        public async Task<Tuple<HttpStatusCode, string, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker)
        {
            try
            {
                List<CompanyProfileJson> companyProfile;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/quote/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

                try
                {
                    var companyProfileJSON = await response.Content.ReadAsStringAsync();
                    companyProfile = JsonConvert.DeserializeObject<List<CompanyProfileJson>>(companyProfileJSON);
                    return new Tuple<HttpStatusCode, string, List<CompanyProfileJson>>(HttpStatusCode.OK, "Success", companyProfile);
                }
                catch(Exception e)
                {
                    return new Tuple<HttpStatusCode, string, List<CompanyProfileJson>>(HttpStatusCode.InternalServerError, "Error occured while deserializing company profile data", null);
                }
            }
            catch (Exception e)
            {
                return new Tuple<HttpStatusCode, string, List<CompanyProfileJson>>(HttpStatusCode.InternalServerError, "Error occured while retrieving company profile data from Financial Modeling Prep", null);
            }
        }

        public async Task<Tuple<HttpStatusCode, string, List<IncomeStatementJson>>> GetAllIncomeStatements(string companyTicker)
        {
            try
            {
                List<IncomeStatementJson> incomeStatements;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/income-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

                try
                {
                    var incomeStatementJSON = await response.Content.ReadAsStringAsync();
                    incomeStatements = JsonConvert.DeserializeObject<List<IncomeStatementJson>>(incomeStatementJSON);
                    return new Tuple<HttpStatusCode, string, List<IncomeStatementJson>>(HttpStatusCode.OK, "Success", incomeStatements);
                }
                catch (Exception e)
                {

                    return new Tuple<HttpStatusCode, string, List<IncomeStatementJson>>(HttpStatusCode.InternalServerError, "Error occured while deserializing income statement data", null);
                }
            }
            catch (Exception e)
            {
                return new Tuple<HttpStatusCode, string, List<IncomeStatementJson>>(HttpStatusCode.InternalServerError, "Error occured while retrieving income statement data from Financial Modeling Prep", null);
            }
            
            
        }

        public async Task<Tuple<HttpStatusCode, string, List<BalanceSheetJson>>> GetAllBalanceSheets(string companyTicker)
        {
            try
            {
                List<BalanceSheetJson> balanceSheets;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/balance-sheet-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

                try
                {
                    var balanceSheetJSON = await response.Content.ReadAsStringAsync();
                    balanceSheets = JsonConvert.DeserializeObject<List<BalanceSheetJson>>(balanceSheetJSON);
                    return new Tuple<HttpStatusCode, string, List<BalanceSheetJson>>(HttpStatusCode.OK, "Success", balanceSheets);
                }
                catch (Exception)
                {
                    return new Tuple<HttpStatusCode, string, List<BalanceSheetJson>>(HttpStatusCode.InternalServerError, "Error occured while deserializing balance sheet data", null);
                }
            }
            catch (Exception)
            {
                return new Tuple<HttpStatusCode, string, List<BalanceSheetJson>>(HttpStatusCode.InternalServerError, "Error occured while retrieving balance sheet data from Financial Modeling Prep", null);
            }  
        }

        public async Task<Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>> GetAllCashFlowStatements(string companyTicker)
        {
            try
            {
                List<CashFlowStatementJson> cashFlowStatements;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/cash-flow-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

                try
                {
                    var cashFlowStatmentJSON = await response.Content.ReadAsStringAsync();
                    cashFlowStatements = JsonConvert.DeserializeObject<List<CashFlowStatementJson>>(cashFlowStatmentJSON);
                    return new Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>(HttpStatusCode.OK, "success", cashFlowStatements);
                }
                catch (Exception)
                {
                    return new Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>(HttpStatusCode.InternalServerError, "Error occured while deserializing cash flow statement data", null);
                }
            }
            catch (Exception)
            {
                return new Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>(HttpStatusCode.InternalServerError, "Error occured while retrieving cash flow statement data from Financial Modeling Prep", null);
            }
        }
    }
}
