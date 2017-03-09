Feature: HomePage
	In order to welcome visitors to my page
	As a Valtech HomePage
	I want to be able to load HomePage contents

Scenario: Latest News section is displayed on HomePage
	Given I launch a firefox browser
	 When I navigate to Valtech homepage
	 Then I see Latest News section

Scenario Outline: HomePage has tab
    Given I launch a firefox browser
	 When I navigate to Valtech homepage
	 Then I see <TabName> tab
Examples: 
| TabName  |
| WORK     |
| SERVICES |
| CAREERS  |
