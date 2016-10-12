using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using UptakeWebsiteTests.Pages;

namespace UptakeWebsiteTests
{
    [TestClass]
    public class UptakeWebsiteTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void ValidateExistenceOfElementsOnHomePage()
        {
            UptakeMainPage uptakeMainPage = new UptakeMainPage(this.Driver);
            uptakeMainPage.Navigate();
            uptakeMainPage.ValidateNavigationToHomePage();
            uptakeMainPage.ValidateUptakeLogoIsDisplayed();
            uptakeMainPage.ValidateTopPageLinksAreDisplayed();
        }

        [TestMethod]
        public void ValidateNavigationFromTopMainPageLinks()
        {
            UptakeMainPage uptakeMainPage = new UptakeMainPage(this.Driver);
            uptakeMainPage.Navigate();
            uptakeMainPage.ValidateNavigationFromTopPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromBodyMainPageLinks()
        {
            UptakeMainPage uptakeMainPage = new UptakeMainPage(this.Driver);
            uptakeMainPage.Navigate();
            uptakeMainPage.ValidateNavigationFromBodyPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromFooterMainPageLinks()
        {
            UptakeMainPage uptakeMainPage = new UptakeMainPage(this.Driver);
            uptakeMainPage.Navigate();
            uptakeMainPage.ValidateNavigationFromFooterPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromTopApproachPageLinks()
        {
            var uptakeApproachPage = new UptakeApproachPage(this.Driver);
            uptakeApproachPage.Navigate();
            uptakeApproachPage.ValidateNavigationFromTopPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromTopPlatformPageLinks()
        {
            var uptakePlatformPage = new UptakePlatformPage(this.Driver);
            uptakePlatformPage.Navigate();
            uptakePlatformPage.ValidateNavigationFromTopPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromTopSolutionsPageLinks()
        {
            var uptakePlatformPage = new UptakeSolutionsPage(this.Driver);
            uptakePlatformPage.Navigate();
            uptakePlatformPage.ValidateNavigationFromTopPageLinks();
        }

        [TestMethod]
        public void ValidateNavigationFromTopPeoplePageLinks()
        {
            var uptakePlatformPage = new UptakePeoplePage(this.Driver);
            uptakePlatformPage.Navigate();
            uptakePlatformPage.ValidateNavigationFromTopPageLinks();
        }


    }
}
