using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
  public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
			
			// Click Sign In 
			Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Sign In')]")).Click();

			// Input Email address
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys("happyava12@outlook.com");

			// Input Password
			Driver.driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("Connect123");
		
            // Click on the Login button
            Driver.driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][contains(text(),'Login')]")).Click();
        }
   }
}
