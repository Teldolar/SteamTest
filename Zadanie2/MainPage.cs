using OpenQA.Selenium;

namespace Task2
{
    public static class MainPage
    {
        private static readonly By SearchLine = By.XPath("//*[contains(@id,'nav_search')]");
        private static readonly By SearchButton = By.XPath("//*[@id='store_search_link']");
        

        public static void FindGameByName(string name)
        {
            DriverUtils.GetDriver().FindElement(SearchLine).SendKeys(name);
            DriverUtils.GetDriver().FindElement(SearchButton).Submit();
        }

        public static By GetSearchLine()
        {
            return SearchLine;
        }
    }
}