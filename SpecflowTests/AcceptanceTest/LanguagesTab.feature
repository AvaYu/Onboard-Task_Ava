Feature: LanguagesTab
	Seller can add a new language record, edit a language record and delete a language record.

Scenario: Check if seller is able to cancel a new language record
	Given I am on the Languages tab under Profile page
	And I have clicked on the Add New button
	And I have input Language name "Chinese" and chosen Language level "Native/Bilingual"
	When I click on the Cancel button
	Then The new Language record shouldn't be added to the listing

Scenario: Check if seller is able to add a new language record
	Given I am on the Languages tab under Profile page
	And I have clicked on the Add New button
	And I have input Language name "Chinese" and chosen Language level "Native/Bilingual"
	When I click on the Add button
	Then The new Language record should be added to the listing

Scenario: Check if seller is able to cancel a edited language record
	Given I am on the Languages tab under Profile page
	And I have added one language record
	And I have clicked on the edit icon of the record
	And I have changed language name to "English" and skill level to "Fluent"
	When I click on the Cancel button
	Then The selected language record shouldn't be updated to the listing

Scenario: Check if seller is able to edit a language record
	Given I am on the Languages tab under Profile page
	And I have added one language record
	And I have clicked on the edit icon of the record
	And I have changed language name to "English" and skill level to "Fluent"
	When I click on the Update button
	Then The selected language record should be updated to the listing

Scenario: Check if seller is able to delete a language record
	Given I am on the Languages tab under Profile page
	And I have added one certification record
	When  I click on the delete icon of the record
	Then The selected language record should be deleted from the listing

Scenario: Check if seller is able to add five language records
	Given I am on the Languages tab under Profile page
	And I have clicked on the Add New button
	And I have input the fourth different language names and chosen the fourth different language levels 
	When I click on the Add button of the fourth record
	Then The Add New button should be disapeared

@LanguagesTab
Scenario: Check if seller is able to see the add new button again
	Given I am on the Languages tab under Profile page
	And I have added four different languages records
	When I click on the delete icon of the first language record
	Then The Add New button should be shown again

