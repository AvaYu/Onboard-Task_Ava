using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
	[Binding]
	public class LanguagesTabSteps
	{
		[Given(@"I am on the Languages tab under Profile page")]
		public void GivenIAmOnTheLanguagesTabUnderProfilePage()
		{
			// Wait 1 second
			Thread.Sleep(1000);
			Driver.driver.FindElement(By.XPath("//a[contains(@class,'item')][contains(text(),'Languages')]")).Click();
		}

		[Given(@"I have added four different languages records")]
		public void GivenIHaveAddedFourDifferentLanguagesrecords()
		{
			string[] languages = new string[]
			{
				"Chinese",
				"English",
				"French",
				"Spanish"
			};

			foreach (string language in languages)
			{
				// Wait 1 second
				Thread.Sleep(1000);

				// Click on the Add New button
				Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//div[contains(@class,'button')][contains(text(),'Add New')]")).Click();

				// Input 4 different language names
				Driver.driver.FindElement(By.Name("name")).SendKeys(language);

				// Choose language levels "Basic"
				Driver.driver.FindElement(By.Name("level")).SendKeys("Basic");

				// Click on the Add button
				Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']")).Click();
			}
		}

		[When(@"I click on the delete icon of the first language record")]
		public void WhenIClickOnTheDeleteIconOfTheFirstLanguageRecord()
		{
			Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//tbody[1]/tr[1]//i[@class='remove icon']")).Click();
		}

		[Then(@"The Add New button should be shown again")]
		public void ThenTheAddNewButtonShouldBeshownAgain()
		{
			// Verify if add the new education successfully
			string buttonText = Driver.driver.FindElement(By.XPath("//div[contains(@class,'active')]//div[contains(@class,'button')][contains(text(),'Add New')]")).Text;
			Assert.That(buttonText, Is.EqualTo("Add New"));
		}
	}
}