Feature: DescriptionContent
	Seller can add new description content, and edit description content.

Scenario: Check if seller is able to add new description content
	Given I am on the Profile page
	And I have clicked on the write icon which right nexts to Description text
	And I have input "Test Analyst experienced with Selenium, C#, Java." in the text area
	When I click on the Save button 
	Then The new description content should be saved under Description tab

Scenario: Check if seller is able to edit description content
	Given I am on the Profile page
	And I have clicked on the write icon which right nexts to Description text
	And I have changed to "Test Analyst wants to learn more about testing." in the text area
	When I click on the Save button 
	Then The new description content should be updated under Description tab