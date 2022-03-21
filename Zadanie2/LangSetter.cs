using System;
using System.IO;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Task2
{
    public static class LangSetter
    {
        public static ChromeOptions SetLang()
        {
            
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument($"--lang={ConvertJsonString()}");
            return chromeOptions;
        }

        private static string ConvertJsonString()
        {
            try
            {
                return (string)JObject.Parse(ReadJsonFile())["language"];
            }
            catch (Exception e)
            {
                Assert.Fail("Can't to convert string");
                throw;
            }
        }
        
        private static string ReadJsonFile()
        {
            try
            {
                using var sr = new StreamReader(@"..\..\..\appsettings.json");
                return sr.ReadToEnd();
            }
            catch 
            {
                Assert.Fail("Can't to find appsettings.json file");
                throw;
            }
        }
    }
}