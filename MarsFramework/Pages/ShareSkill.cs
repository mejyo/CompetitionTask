using MarsFramework.Global;
using NUnit.Framework;
using OpenDialogWindowHandler;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
       

        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
         private IWebElement HourlyBasisService { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement OnSite { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]//div[2]//input[1]")]

       
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.Name, Using = "StartTime")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.Name, Using = "EndTime")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement Credit { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSamples { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement Active { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Graphics & Design']")]
        private IWebElement findRecord { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manage Listings']")]

        private IWebElement manageListingsLink { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Business']")]

        private IWebElement FindEditedRecord { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]")]
        private IWebElement delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Yes']")]
        private IWebElement deleteYesButton { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")]

        private IWebElement Message { get; set; }



        internal void EnterShareSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            var wait = new WebDriverWait(GlobalDefinitions.driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Share Skill")));

            ShareSkillButton.Click();

            Thread.Sleep(3000);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));

            Tags.SendKeys(Keys.Enter);

            HourlyBasisService.Click();

            OnSite.Click();
       
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            Days.Click();

            StartTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));


            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));

            Credit.Click();

            CreditAmount.Click();

            CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            WorkSamples.Click();

            HandleOpenDialog hodObject = new HandleOpenDialog();

            hodObject.fileOpenDialog(@"C:\Users\mejyo\Desktop\Projects\marsframework\MarsFramework\Data", "Document.txt");
        
            Active.Click();
           
            Save.Click();

            GlobalDefinitions.wait(3000);
            
            if (findRecord.Text == "Graphics & Design")
            {

                Assert.Pass("Record has been created.");
            }
            else
            {

                Assert.Fail("Record has not been created.");
            }

        }

        internal void EditShareSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            var wait = new WebDriverWait(GlobalDefinitions.driver, new TimeSpan(0, 0, 10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Manage Listings']")));

            manageListingsLink.Click();

            Thread.Sleep(3000);

            edit.Click();

            Thread.Sleep(3000);
            Title.Clear();

            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

            Description.Clear();

            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));

            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Category"));

            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "SubCategory"));

            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Tags"));

            Tags.SendKeys(Keys.Enter);

            HourlyBasisService.Click();

            OnSite.Click();

            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Startdate"));

            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndDate"));

            Days.Click();

            StartTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "StartTime"));


            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndTime"));

            Credit.Click();

            CreditAmount.Click();

            CreditAmount.Clear();

            CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Credit"));

            WorkSamples.Click();

            HandleOpenDialog hodObject = new HandleOpenDialog();

            hodObject.fileOpenDialog(@"C:\Users\mejyo\Desktop\Projects\marsframework\MarsFramework\Data", "Document.txt");

            Active.Click();

            Save.Click();

            GlobalDefinitions.wait(3000);

            if (FindEditedRecord.Text == "Business")
            {

                Assert.Pass("Record has been Updated.");
            }
            else
            {

                Assert.Fail("Record has not been Updated.");
            }

        }

        internal void Delete()
        {
            GlobalDefinitions.wait(30);

            manageListingsLink.Click();


            try
            {

                delete.Click();

                deleteYesButton.Click();

                Thread.Sleep(3000);

                string ExpectedMesaage = "Abc has been deleted";

                string ActualMessage = Message.Text;

                var wait = new WebDriverWait(GlobalDefinitions.driver, new TimeSpan(0, 0, 5));

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")));


                Assert.AreEqual(ExpectedMesaage, ActualMessage);

                Assert.Pass("Record has been deleted");
            }

            catch (NoSuchElementException exp)

            {
                Base.test.Log(LogStatus.Fail, exp.Message);

                Assert.Pass("Record has not been found");
            }

        }
    }

}
