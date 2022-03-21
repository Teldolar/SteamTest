using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;

namespace Task2
{
    [TestFixture]
    public class Tests
    {
        
        private static object[] _testCase =
        {
            new object[] {"The Witcher", 10},
            new object[] {"Fallout", 20}
        };

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
        }

        [Test]
        [TestCaseSource(nameof(_testCase))]
        public void Test1(string name,int count)
        {
            DriverUtils.GetDriver().Navigate().GoToUrl("https://store.steampowered.com");
            DriverUtils.GetWait().Until(driver => driver.FindElement(MainPage.GetSearchLine()).Displayed);
            MainPage.FindGameByName(name);
            DriverUtils.GetWait().Until(driver => driver.FindElement(SearchPage.GetSortComboBox()).Displayed);
            SearchPage.SortByPriceDecrease();
            DriverUtils.GetWait().Until(driver => !driver.Url.Contains("force_infinite"));
            Assert.IsTrue(SortChecker.IsSorted(SearchPage.GetElementPrices(count)));
        }
    }
}