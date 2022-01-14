using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsFramework
{
    public class Program
    {
        

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order(1)]
            public void ShareSkillAdd()
            {


                ShareSkill shareSkillObj = new ShareSkill();

                shareSkillObj.EnterShareSkill();
            }
            [Test, Order(2)]
            public void ShareSkillAddOther()
            {


                ShareSkill shareSkillObj = new ShareSkill();

                shareSkillObj.EnterShareSkill();
            }

            [Test, Order(3)]
            public void ShareSkillEdit()
                {


                    ShareSkill EditshareSkillObj = new ShareSkill();

                    EditshareSkillObj.EditShareSkill();

            }



            [Test, Order(4)]
            public void ManageListingsEdit()
            {

                ManageListings manageListingsObj = new ManageListings();

                manageListingsObj.Listings();

            }


            [Test, Order(5)]
            public void DeleteManageListings()
            {

              ManageListings manageListingsObj = new ManageListings();

               manageListingsObj.DeleteListings();


            }
            [Test, Order(6)]
            public void DeleteShareSkill()
            {

               ShareSkill DeleteshareSkillObj = new ShareSkill();

               DeleteshareSkillObj.Delete();


            }
        }
    }
}