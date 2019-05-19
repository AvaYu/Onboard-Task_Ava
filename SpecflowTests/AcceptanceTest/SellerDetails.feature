Feature: SellerDetails
	Seller can edit name, edit availability, edit hours and edit earn target.

Scenario: Check if seller is able to edit name
	Given I am on the Profile page
	And I have clicked on the dropdown icon of a seller's name
	And I have changed seller's first name to "Test" and last name to "Analyst"
	When I click on the Save button 
	Then The seller's name should be saved

Scenario: Check if seller is able to edit availability
	Given I am on the Profile page
	And I have clicked on the edit icon of seller's availability
	And I have clicked on the dropdown icon
	When I have clicked on the option "Full Time" of seller's availability
	Then The seller's availability should be updated

Scenario: Check if seller is able to edit hours
	Given I am on the Profile page
	And I have clicked on the edit icon of seller's hours
	And I have clicked on the dropdown icon
	When I have clicked on the option "More than 30hours a week" of seller's hours
	Then The seller's hours should be updated

Scenario: Check if seller is able to edit earn target
	Given I am on the Profile page
	And I have clicked on the edit icon of seller's earn target
	And I have clicked on the dropdown icon
	When I have clicked on the option "More than $1000 per month" seller's earn target
	Then The seller's earn target should be updated
