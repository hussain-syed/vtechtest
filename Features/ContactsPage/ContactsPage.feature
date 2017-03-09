Feature: ContactsPage
	In order to reveal contact details or Valtech world wide
	As a ContactsPage
	I should be able to reveal Valtech's worldwide location details


Scenario: Assert that the number of Valtech offices worldwide are shown correctly
	Given I launch a chrome browser
      And I am on HomePage of Valtech
	 When I navigate to Contacts page
	 Then I find 29 locations for Valtech offices
