using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsFramework
{
    public class Program
    {
        

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order(1)]
            public void ShareSkill()
            {
                GlobalDefinitions.wait(30);

                ShareSkill shareSkillObj = new ShareSkill();

                shareSkillObj.EnterShareSkill();
            }

            [Test, Order(2)]
            public void ManageListings()
            {

                GlobalDefinitions.wait(30);

                ManageListings manageListingsObj = new ManageListings();

                manageListingsObj.Listings();


                  
            }


            [Test, Order(3)]
            public void DeleteManageListings()
            {

                GlobalDefinitions.wait(30);

                ManageListings manageListingsObj = new ManageListings();

                manageListingsObj.DeleteListings();



            }
        }
    }
}