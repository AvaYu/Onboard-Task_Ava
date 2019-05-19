Feature: SkillsTab
	Seller can add a new skill record, edit a skill record and delete a skill record.

Scenario: Check if seller is able to cancel a new skill record
	Given I am on the Skills tab under Profile page
	And I have clicked on the Add New button
	And I have input skill name "C#" and chosen skill level "Expert"
	When I click on the Cancel button
	Then The new skill record shouldn't be added to the listing

Scenario: Check if seller is able to add a new skill record
	Given I am on the Skills tab under Profile page
	And I have clicked on the Add New button
	And I have input skill name "C#" and chosen skill level "Expert"
	When I click on the Add button
	Then The new skill record should be added to the listing

Scenario: Check if seller is able to cancel a edited skill record
	Given I am on the Skills tab under Profile page
	And I have clicked on the edit icon of a skill record
	And I have changed skill name to "Java" and skill level to "Beginner"
	When I click on the Cancel button
	Then The selected skill record shouldn't be updated to the listing

Scenario: Check if seller is able to edit a skill record
	Given I am on the Skills tab under Profile page
	And I have clicked on the edit icon of a skill record
	And I have changed skill name to "Java" and skill level to "Beginner"
	When I click on the Update button
	Then The selected skill record should be updated to the listing

Scenario: Check if seller is able to delete a skill record
	Given I am on the Skills tab under Profile page
	When  I click on the delete icon of a skill record
	Then The selected skill record should be deleted from the listing