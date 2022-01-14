using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EditandDeleteTime.Utilities
{
    public class wait
    {
        

        public static void WaitTobeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locator == "XPath")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));

            }

            if (locator == "Id")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));

            }


            if (locator == "CssSelector")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            }

        }

        internal static void WaitTobeVisible(IWebDriver driver, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public static void WaitTobeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)

        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locator == "XPath")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible (By.XPath(locatorValue)));

            }

            if (locator == "Id")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));

            }


            if (locator == "CssSelector")

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));

            }

        }

    }
}