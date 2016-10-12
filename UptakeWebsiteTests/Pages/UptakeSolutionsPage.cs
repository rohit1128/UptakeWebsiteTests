using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UptakeWebsiteTests.Pages
{
    public class UptakeSolutionsPage : UptakeBasePage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://uptake.com/solutions";

        public UptakeSolutionsPage(IWebDriver browser)
        {
            this.Driver = browser;
            this.Url = url;
            PageFactory.InitElements(browser, this);
        }        
    }
}
