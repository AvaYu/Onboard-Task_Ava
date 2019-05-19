Feature: EducationTab
	Seller can add a new education record, edit a education record and delete a education record.

Scenario: Check if seller is able to cancel a new education record
	Given I am on the Education tab under Profile page
	And I have clicked on the Add New button
	And I have input College/University Name "Oxford" and chosen Country of College/University "United Kingdom"
	And I have chosen Title "PHD", input Degree "Master" and chosen Year of graduation "2018"
	When I click on the Cancel button
	Then The new education record shouldn't be added to the listing

@EducationTab
Scenario: Check if seller is able to add a new education record
	Given I am on the Education tab under Profile page
	And I have clicked on the Add New button
	And I have input College/University Name "Oxford" and chosen Country of College/University "United Kingdom"
	And I have chosen Title "PHD", input Degree "Master" and chosen Year of graduation "2018"
	When I click on the Add button
	Then The new education record should be added to the listing

Scenario: Check if seller is able to cancel a edited education record
	Given I am on the Education tab under Profile page
	And I have added one education record
	And I have clicked on the edit icon of the record
	And I have changed College/University Name to "Harvard" and Country of College/University to "United States"
	And I have also changed Title to "M.B.A", Degree to "Bachelor" and Year of graduation to "2017"
	When I click on the Cancel button
	Then The selected education record shouldn't be updated to the listing

Scenario: Check if seller is able to edit a education record
	Given I am on the Education tab under Profile page
	And I have added one education record
	And I have clicked on the edit icon of the record
	And I have changed College/University Name to "Harvard" and Country of College/University to "United States"
	And I have also changed Title to "M.B.A", Degree to "Bachelor" and Year of graduation to "2017"
	When I click on the Update button
	Then The selected education record should be updated to the listing

Scenario: Check if seller is able to delete a education record
	Given I am on the Education tab under Profile page
	And I have added one education record
	When I click on the delete icon of the record
	Then The selected education record should be deleted from the listing