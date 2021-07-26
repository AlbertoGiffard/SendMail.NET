using CampaignFileAttacher;
using CampaignSender;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CampaignAndAttachTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void AddCampaignToBaseCampaign()
        {
            //Arrange
            BaseCampaign b1 = new BaseCampaign("test");
            Campaign c1 = new Campaign(1, "subject", "body", null, DateTime.Now);

            //Act
            b1 += c1;

            //Assert
            Assert.IsNotNull(b1.CampaignList);
        }

        [TestMethod]
        public void SendACampaign()
        {
            //Arrange
            List<Email> l1 = new List<Email>();
            l1.Add(new Email("junior@prueba.com", "junior"));
            Campaign c1 = new Campaign(1, "subject", "body", l1, DateTime.Now);

            //Act/Assert
            Assert.IsTrue(SendMail.SendCampaign(c1));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DoNotAddCampaignCauseExistTheId()
        {
            //Arrange
            BaseCampaign b1 = new BaseCampaign("test");
            Campaign c1 = new Campaign(1, "subject", "body", null, DateTime.Now);
            Campaign c2 = new Campaign(1, "subject", "body", null, DateTime.Now);
            b1 += c1;

            //Act
            b1 += c2;
        }
        [TestMethod]
        public void CompareIsTrueBecauseIsADifferentId()
        {
            //Arrange
            BaseCampaign b1 = new BaseCampaign("test");
            Campaign c1 = new Campaign(1, "subject", "body", null, DateTime.Now);
            Campaign c2 = new Campaign(1, "subject", "body", null, DateTime.Now);
            b1 += c1;

            //Act/Assert
            Assert.IsTrue(b1 == c2);
        }
        [TestMethod]
        public void AddNewEmail()
        {
            //Arrange
            Email email = new Email("junior@prueba.com", "junior");
            List<Email> list = new List<Email>();

            //act
            ActionEmail.AddNewEmail(email, list);

            //Assert
            Assert.IsTrue(list.Count > 0);
        }
        [TestMethod]
        public void ShowAllEmails()
        {
            //Arrange
            Campaign campaign = new Campaign();

            //Act/Assert
            Assert.AreEqual($"Aún sin destinatarios.", ActionEmail.ShowAllEmails(campaign));
        }
        [TestMethod]
        public void RemoveAllEmailAdress()
        {
            //Arrange
            List<Email> list = new List<Email>();
            Campaign campaign = new Campaign(1, "subject", "body", list, DateTime.Now);
            Email e1 = new Email("junior@prueba.com", "Junior");
            Email e2 = new Email("sofia@prueba.com", "Sofia");

            //Act
            ActionEmail.AddNewEmail(e1, campaign.EmailList);
            ActionEmail.AddNewEmail(e2, campaign.EmailList);

            //Assert
            Assert.IsTrue(ActionEmail.RemoveAllEmails(campaign));
        }
    }
}
