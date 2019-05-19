Feature: CertificationsTab
	Seller can add a new certification record, edit a certification record and delete a certification record.

Scenario: Check if seller is able to cancel a new certification record
	Given I am on the Certifications tab under Profile page
	And I have clicked on the Add New button
	And I have input Certificate or Award "Information Technology", Certified From "Adobe" and chosen Year "2018"
	When I click on the Cancel button
	Then The new certification record shouldn't be added to the listing

Scenario: Check if seller is able to add new a certification record
	Given I am on the Certifications tab under Profile page
	And I have clicked on the Add New button
	And I have input Certificate or Award "Information Technology", Certified From "Adobe" and chosen Year "2018"
	When I click on the Add button
	Then The new certification record should be added to the listing

Scenario: Check if seller is able to cancel a edited certification record
	Given I am on the Certifications tab under Profile page
	And I have added one certification record
	And I have clicked on the edit icon of the record
	And I have changed Certificate or Award to "Computer Science", Certified From to "AUT" and chosen Year to "2017"
	When I click on the Cancel button
	Then The selected certification record shouldn't be updated to the listing

@CertificationTab
Scenario: Check if seller is able to edit a certification record
	Given I am on the Certifications tab under Profile page
	And I have added one certification record
	And I have clicked on the edit icon of the record
	And I have changed Certificate or Award to "Computer Science", Certified From to "AUT" and chosen Year to "2017"
	When I click on the Update button
	Then The selected certification record should be updated to the listing

Scenario: Check if seller is able to delete a certification record
	Given I am on the Certifications tab under Profile page
	And I have added one certification record
	When I click on the delete icon of the record
	Then The selected certification record should be deleted from the listing