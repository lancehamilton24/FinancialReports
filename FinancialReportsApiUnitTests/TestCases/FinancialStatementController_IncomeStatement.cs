using FinancialReportingApi.Controllers;
using NUnit.Framework;

namespace FinancialReportsApiUnitTests
{
    public class FinancialStatementController_IncomeStatement
    {
        private FinancialStatementController _financialStatementController;

        [SetUp]
        public void Setup()
        {
            _financialStatementController = new FinancialStatementController();
        }

        [Test]
        public void GetAllCompanyIncomeStatements_ShouldPass()
        {
            var result = _financialStatementController.GetAllIncomeStatements("PYPL").Result.Value;
            Assert.NotNull(result);
        }
    }
}