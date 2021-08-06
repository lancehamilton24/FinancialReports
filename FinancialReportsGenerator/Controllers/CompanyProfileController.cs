using FinancialReportsApiClient.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsApiClient.Controllers
{
    [ApiController]
    [EnableCors("My Policy")]
    [Route("api/[controller]")]
    public class CompanyProfileController : Controller
    {
         [HttpGet("companyprofile/{companyTicker}")]
         public async Task<List<CompanyProfileJson>> GetCompanyProfile(string companyTicker)
         {
             List<CompanyProfileJson> companyProfile;
             var client = new HttpClient();
             client.BaseAddress = new Uri("https://financialmodelingprep.com/");
             client.DefaultRequestHeaders.Accept.Clear();
             client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             //GET Method  
             HttpResponseMessage response = await client.GetAsync($"api/v3/quote/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

             var companyProfileJSON = await response.Content.ReadAsStringAsync();
            companyProfile = JsonConvert.DeserializeObject<List<CompanyProfileJson>>(companyProfileJSON);
             return companyProfile;
         }
    }
}
