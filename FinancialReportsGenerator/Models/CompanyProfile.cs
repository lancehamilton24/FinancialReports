namespace FinancialReportsGenerator.Models
{
    public class CompanyProfile
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public long YearHigh { get; set; }
        public double YearLow { get; set; }
        public long MarketCap { get; set; }
        public double Eps { get; set; }
        public double Pe { get; set; }
    }
}
