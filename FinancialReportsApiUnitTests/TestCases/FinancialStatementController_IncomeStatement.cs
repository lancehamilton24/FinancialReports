using FinancialReportsApiClient.Controllers;
using NUnit.Framework;

namespace FinancialReportsApiUnitTests
{
    public class FinancialStatementController_IncomeStatement
    {
        private FinancialStatementsController _financialStatementController;

        [SetUp]
        public void Setup()
        {
            _financialStatementController = new FinancialStatementsController();
        }

        [Test]
        public void GetAllCompanyIncomeStatements_ShouldPass()
        {
            var result = _financialStatementController.GetAllIncomeStatements("PYPL").Result;
            Assert.NotNull(result);
        }
    }
}