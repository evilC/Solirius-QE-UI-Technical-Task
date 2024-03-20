Feature: Days worked per week
	Verify correct answers for Days worked per week

Scenario: Five days a week for a full year
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for a full leave year'
	And the user enters '5' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '28' days

Scenario: Three days a week for a full year
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for a full leave year'
	And the user enters '3' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '16.8' days

Scenario: Three days a week starting part way
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for someone starting part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment start date'
	And the user enters the date '01-06-2023' as 'the leave year start date'
	And the user enters '3' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '7' days

Scenario: Three days a week leaving part way
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for someone leaving part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment end date'
	And the user enters the date '01-06-2023' as 'the leave year start date'
	And the user enters '3' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '9.9' days

Scenario: Three days a week starting and leaving part way
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for someone starting and leaving part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment start date'
	And the user enters the date '01-06-2024' as 'the employment end date'
	And the user enters '3' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '7.1' days





