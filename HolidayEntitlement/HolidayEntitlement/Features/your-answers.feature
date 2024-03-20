Feature: Your Answers
	Verify that the "Your Answers" section is correctly populated

Scenario: Selecting days worked per week should populate Your Answers correctly
	Given the user is on the Base page
	When the user selects 'days worked per week'
	Then the last answer should read 'Is the holiday entitlement based on:' and 'days worked per week'

Scenario: Selecting full year should populate Your Answers correctly
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for a full leave year'
	Then the last answer should read 'Do you want to work out holiday:' and 'for a full leave year'
