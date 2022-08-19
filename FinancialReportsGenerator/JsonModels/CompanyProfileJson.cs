using Newtonsoft.Json;
using System;

namespace FinancialReportsGenerator.JsonModels
{
    public class CompanyProfileJson
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("beta")]
        public double Beta { get; set; }

        [JsonProperty("volAvg")]
        public long VolAvg { get; set; }

        [JsonProperty("mktCap")]
        public long MktCap { get; set; }

        [JsonProperty("lastDiv")]
        public double LastDiv { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("changes")]
        public double Changes { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("exchangeShortName")]
        public string ExchangeShortName { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("website")]
        public Uri Website { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ceo")]
        public string Ceo { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fullTimeEmployees")]
        public long FullTimeEmployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public long Zip { get; set; }

        [JsonProperty("dcfDiff")]
        public double? DcfDiff { get; set; }

        [JsonProperty("dcf")]
        public double Dcf { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("ipoDate")]
        public DateTimeOffset IpoDate { get; set; }

        [JsonProperty("defaultImage")]
        public bool DefaultImage { get; set; }

        [JsonProperty("isEtf")]
        public bool IsEtf { get; set; }

        [JsonProperty("isActivelyTrading")]
        public bool IsActivelyTrading { get; set; }

        [JsonProperty("isAdr")]
        public bool IsAdr { get; set; }

        [JsonProperty("isFund")]
        public bool IsFund { get; set; }
    }
}
