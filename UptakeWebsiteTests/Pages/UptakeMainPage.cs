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
    public class UptakeMainPage:UptakeBasePage
    {
        private readonly string url = @"http://uptake.com/";

        public UptakeMainPage(IWebDriver browser)
        {
            this.Driver = browser;
            this.Url = url;

            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/approach']")]
        public IWebElement BodyApproachLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/platform']")]
        public IWebElement BodyPlatformLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/solutions']")]
        public IWebElement BodySolutionsLink { get; set; }

        public void ValidateNavigationToHomePage()
        {
            Assert.AreEqual("Uptake – Analytics for the Industrial Internet", Driver.Title, "The Navigation to the Uptake home page failed.");
        }

        public void ValidateUptakeLogoIsDisplayed()
        {
            Assert.IsTrue(this.Logo.Displayed, "The Uptake Logo is not displayed on the home page.");
        }
        public void ValidateTopPageLinksAreDisplayed()
        {
            Assert.IsTrue(this.ApproachLink.Displayed, "The Approach link is not displayed on the home page.");
            Assert.AreEqual("Approach", this.ApproachLink.Text, "The Approach link text is incorrect.");

            Assert.IsTrue(this.PlatformLink.Displayed, "The Platform link is not displayed on the home page.");
            Assert.AreEqual("Platform", this.PlatformLink.Text, "The Platform link text is incorrect.");

            Assert.IsTrue(this.SolutionsLink.Displayed, "The Solutions link is not displayed on the home page.");
            Assert.AreEqual( "Solutions", this.SolutionsLink.Text, "The Solutions link text is incorrect.");

            Assert.IsTrue(this.PeopleLink.Displayed, "The People link is not displayed on the home page.");
            Assert.AreEqual( "People", this.PeopleLink.Text, "The People link text is incorrect.");

            Assert.IsTrue(this.JoinUsLink.Displayed, "The Join Us link is not displayed on the home page.");
            Assert.AreEqual( "Join Us", this.JoinUsLink.Text, "The Join Us link text is incorrect.");

            Assert.IsTrue(this.ContactUsLink.Displayed, "The Contact Us link is not displayed on the home page.");
            Assert.AreEqual( "Contact Us", this.ContactUsLink.Text, "The Contact Us link text is incorrect.");
        }

        public void ValidateNavigationFromBodyPageLinks()
        {
            Assert.AreEqual("Learn more about our approach ›", BodyApproachLink.Text, " Body Approach link text incorrect");
            BodyApproachLink.Click();
            Assert.AreEqual("Approach – Uptake", Driver.Title, "Navigation from Approach Link Failed");
            Navigate();

            Assert.AreEqual("Learn more about our platform ›", BodyPlatformLink.Text, " Body Platform link text incorrect");
            BodyPlatformLink.Click();
            Assert.AreEqual("Platform – Uptake", Driver.Title, "Navigation from Platform Link Failed");
            Navigate();

            Assert.AreEqual("Learn more about our solutions ›", BodySolutionsLink.Text, " Body Solutions link text incorrect");
            BodySolutionsLink.Click();
            Assert.AreEqual("Solutions – Uptake", Driver.Title, "Navigation from Solutions Link Failed");
            Navigate();
        }
    }
}
