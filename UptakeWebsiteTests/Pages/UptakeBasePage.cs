using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UptakeWebsiteTests.Pages
{
    public class UptakeBasePage
    {
        private IWebDriver driver=null;
        private string url = @"http://uptake.com/";

        [FindsBy(How = How.CssSelector, Using = @"a[href='/']")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://uptake.com/approach/']")]
        public IWebElement ApproachLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://uptake.com/platform/']")]
        public IWebElement PlatformLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://uptake.com/solutions/']")]
        public IWebElement SolutionsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://uptake.com/people/']")]
        public IWebElement PeopleLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/jobs/']")]
        public IWebElement JoinUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='mailto:info@uptake.com']")]
        public IWebElement ContactUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://uptake.com/ourblog/']")]
        public IWebElement BlogLink { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@class='footer__menu']/ul/li/a[@href='/approach']")]
        public IWebElement FooterApproachLink { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@class='footer__menu']/ul/li/a[@href='/platform']")]
        public IWebElement FooterPlatformLink { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@class='footer__menu']/ul/li/a[@href='/people']")]
        public IWebElement FooterPeopleLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='http://beyond.uptake.com']")]
        public IWebElement FooterPhilanthropyLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/newsroom']")]
        public IWebElement FooterMediaLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/jobs']")]
        public IWebElement FooterJoinUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a[href='/ourblog']")]
        public IWebElement FooterBlogLink { get; set; }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }


        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }
        public void ValidateNavigationFromTopPageLinks()
        {
            ApproachLink.Click();
            Assert.AreEqual("Approach – Uptake", Driver.Title, "Navigation from Approach Link Failed");
            Navigate();

            PlatformLink.Click();
            Assert.AreEqual("Platform – Uptake", Driver.Title, "Navigation from Platform Link Failed");
            Navigate();

            SolutionsLink.Click();
            Assert.AreEqual("Solutions – Uptake", Driver.Title, "Navigation from Solutions Link Failed");
            Navigate();

            PeopleLink.Click();
            Assert.AreEqual("People – Uptake", Driver.Title, "Navigation from People Link Failed");
            Navigate();

            JoinUsLink.Click();
            Assert.AreEqual("Join Us | Uptake", Driver.Title, "Navigation from Contact Us Link Failed");
            Navigate();

            ContactUsLink.Click();
            Assert.IsTrue(ValidateNavigationToContactUsPage(), "Navigation from Contact Us Link Failed");
            Navigate();

            BlogLink.Click();
            Assert.AreEqual("Blog – Uptake", Driver.Title, "Navigation from Blog Link Failed");
            Navigate();
        }

        public bool ValidateNavigationToContactUsPage()
        {
            var formText = Driver.FindElements(By.XPath("//h2[text()='Curious to learn how Uptake can impact your company? Contact us below.']"));
            return formText.Count > 0;
        }
        public void ValidateNavigationFromFooterPageLinks()
        {
            FooterApproachLink.Click();
            Assert.AreEqual("Approach – Uptake", Driver.Title, "Navigation from Approach Link Failed");
            Navigate();

            FooterPlatformLink.Click();
            Assert.AreEqual("Platform – Uptake", Driver.Title, "Navigation from Platform Link Failed");
            Navigate();

            FooterPeopleLink.Click();
            Assert.AreEqual("People – Uptake", Driver.Title, "Navigation from People Link Failed");
            Navigate();

            FooterMediaLink.Click();
            Assert.AreEqual("Newsroom – Uptake", Driver.Title, "Navigation from Media Link Failed");
            Navigate();

   
            FooterBlogLink.Click();
            Assert.AreEqual("Blog – Uptake", Driver.Title, "Navigation from Blog Link Failed");
            Navigate();
        }
    }
}
