using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace Task2
{
    public static class DriverUtils
    {
        private static readonly IWebDriver Driver = new ChromeDriver(LangSetter.SetLang());
        private static readonly WebDriverWait Wait = new(GetDriver(), new TimeSpan(0,0,20)); 
        

        public static IWebDriver GetDriver()
        {
            return Driver;
        }
        
        public static WebDriverWait GetWait()
        {
            return Wait;
        }
    }
}