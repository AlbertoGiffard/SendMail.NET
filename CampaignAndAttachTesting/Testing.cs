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
    }
}
