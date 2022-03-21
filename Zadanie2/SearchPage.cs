using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;

namespace Task2
{
    public static class SearchPage
    {
        private static readonly By SortComboBox = By.XPath("//*[@id='sort_by_trigger']");
        private static readonly By PriceDecrease = By.XPath("//*[@id='Price_DESC']");
        private static readonly By PriceElementPath = By.XPath("//div[contains(@class,'price_discount')]");

        public static By GetSortComboBox()
        {
            return SortComboBox;
        }
        
        public static void SortByPriceDecrease()
        {
            DriverUtils.GetDriver().FindElement(SortComboBox).Click();
            DriverUtils.GetDriver().FindElement(PriceDecrease).Click();
        }

        public static List<string> GetElementPrices(int count)
        {
            var prices = new List<string>();
            var priceElements = DriverUtils.GetDriver().FindElements(PriceElementPath);
            for (var i = 0; i < count; i++)
            {
                prices.Add(priceElements.ElementAt(i).GetAttribute("data-price-final"));
            }
            return prices;
        }
    }
}