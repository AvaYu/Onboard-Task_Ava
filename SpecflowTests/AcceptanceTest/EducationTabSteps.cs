using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
	[Binding]
	public class EducationTabSteps
	{
		[Given(@"I am on the Education tab under Profile page")]
		public void GivenIAmOnTheEducationTabUnderProfilePage()
		{
			// Wait 1 second
			Thread.Sleep(1000);

			// Click on the Education cab
			Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]")).Click();
		}

		[Scope(Tag = "EducationTab")]
		[Given(@"I have clicked on the Add New button")]
		public void GivenIHaveClickedOnTheAddNewButton()
		{
			// Wait 1 second
			Thread.Sleep(1000);

			Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//div[contains(@class,'button')][contains(text(),'Add New')]")).Click();
		}

		[Given(@"I have input College/University Name ""(.*)"" and chosen Country of College/University ""(.*)""")]
		public void GivenIHaveInputCollegeUniversityNameAndChosenCountryOfCollegeUniversity(string Name, string Country)
		{
			// Input College/University Name "Oxford"
			Driver.driver.FindElement(By.Name("instituteName")).SendKeys(Name);

			// Choose Country of College/University "United Kingdom"
			Driver.driver.FindElement(By.Name("country")).SendKeys(Country);
		}

		[Given(@"I have chosen Title ""(.*)"", input Degree ""(.*)"" and chosen Year of graduation ""(.*)""")]
		public void GivenIHaveChosenTitleInputDegreeAndChosenYearOfGraduation(string Title, string Degree, string Year)
		{
			// Choose Title "PHD"
			Driver.driver.FindElement(By.Name("title")).SendKeys(Title);

			// Input Degree "Master"
			Driver.driver.FindElement(By.Name("degree")).SendKeys(Degree);

			// Choose Year of graduation "2018"
			Driver.driver.FindElement(By.Name("yearOfGraduation")).SendKeys(Year);

		}

		[Scope(Tag = "EducationTab")]
		[When(@"I click on the Add button")]
		public void WhenIClickOnTheAddButton()
		{
			Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']")).Click();
		}

		[Then(@"The new education record should be added to the listing")]
		public void ThenTheNewEducationRecordShouldBeAddedToTheListing()
		{
			// Verify if add the new education successfully
			IWebElement actualName = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Oxford')]"));
			Assert.That(actualName != null);

			IWebElement actualCountry = Driver.driver.FindElement(By.XPath("//td[contains(text(),'United Kingdom')]"));
			Assert.That(actualName != null);

			IWebElement actualTitle = Driver.driver.FindElement(By.XPath("//td[contains(text(),'PHD')]"));
			Assert.That(actualName != null);

			IWebElement actualDegree = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Master')]"));
			Assert.That(actualName != null);

			IWebElement actualYear = Driver.driver.FindElement(By.XPath("//td[contains(text(),'2018')]"));
			Assert.That(actualName != null);
		}
	}
}