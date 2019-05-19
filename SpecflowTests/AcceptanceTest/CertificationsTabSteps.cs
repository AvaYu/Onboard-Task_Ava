using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    [Binding]
    public class CertificationsTabSteps
    {
		[Given(@"I am on the Certifications tab under Profile page")]
        public void GivenIAmOnTheCertificationsTabUnderProfilePage()
        {
			// Wait 1 second
			Thread.Sleep(1000);

			// Click on the Certification cab
			Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Certifications')]")).Click();
		}

		[Scope(Tag = "CertificationTab")]
		[Given(@"I have added one certification record")]
		public void GivenIHaveAddedOneCertificationRecord()
		{
			// Wait 1 second
			Thread.Sleep(1000);

			// Click on the Add New button
			Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//div[contains(@class,'button')][contains(text(),'Add New')]")).Click();

			// Input Certificate or Award "Information Technology"
			Driver.driver.FindElement(By.Name("certificationName")).SendKeys("Information Technology");

			// Input Certified From "Adobe" 
			Driver.driver.FindElement(By.Name("certificationFrom")).SendKeys("Adobe");

			// Choose Year "2018"
			Driver.driver.FindElement(By.Name("certificationYear")).SendKeys("2018");

			// Click on the Add button
			Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']")).Click();
		}
	
		[Given(@"I have clicked on the edit icon of the record")]
        public void GivenIHaveClickedOnTheEditIconOftheRecord()
        {
			Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//tbody/tr[1]//i[@class='outline write icon']")).Click();
        }
        
        [Given(@"I have changed Certificate or Award to ""(.*)"", Certified From to ""(.*)"" and chosen Year to ""(.*)""")]
        public void GivenIHaveChangedCertificateOrAwardToCertifiedFormToAndChosenYearTo(string Certificate, string From, string Year)
        {
			// Change Certificate or Award to "Computer Science"
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']")).Clear();
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']")).SendKeys(Certificate);

			// Change Certified From to "AUT"
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']")).Clear();
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']")).SendKeys(From);

			// Change Year to "2017"
			Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']")).SendKeys(Year);
		}

		[Scope(Tag = "CertificationTab")]
		[When(@"I click on the Update button")]
        public void WhenIClickOnTheUpdateButton()
        {
			Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Update']")).Click();
        }
		

		[Then(@"The selected certification record should be updated to the listing")]
        public void ThenTheSelectedCertificationRecordShouldBeUpdatedToTheListing()
        {
			// Verify if add the new education successfully
			IWebElement actualName = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Computer Science')]"));
			Assert.That(actualName != null);

			IWebElement actualCountry = Driver.driver.FindElement(By.XPath("//td[contains(text(),'AUT')]"));
			Assert.That(actualCountry != null);

			IWebElement actualYear = Driver.driver.FindElement(By.XPath("//td[contains(text(),'2017')]"));
			Assert.That(actualYear != null);
		}
    }
}