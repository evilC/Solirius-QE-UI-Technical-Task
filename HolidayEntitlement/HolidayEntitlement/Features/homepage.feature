Feature: Home Page
	Tests for the home (Landing) page

Scenario: Navigate to Base Page
	Given the user is on the Homepage
	When the user clicks 'Start now'
	Then the browser should navigate to the base page