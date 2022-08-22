//using FinancialReportsGenerator.Controllers;
//using FinancialReportsGenerator.Models;
//using NUnit.Framework;

//namespace FinancialReportsApiUnitTests
//{
//    public class FinancialStatementController_IncomeStatement
//    {
//        private FinancialStatementsController _financialStatementController;

//        [SetUp]
//        public void Setup()
//        {
//            _financialStatementController = new FinancialStatementsController();
//        }

//        [Test]
//        public void GetCompanyFinancialReport_ShouldPass()
//        {
//            FinancialStatement financialReport = new FinancialStatement();
//            financialReport = _financialStatementController.GetAllFinancialStatements("PYPL").Result;
//            Assert.NotNull(financialReport);
//        }
//    }
//}