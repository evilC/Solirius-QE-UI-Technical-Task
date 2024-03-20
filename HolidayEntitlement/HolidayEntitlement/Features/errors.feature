Feature: Errors
	Verify that appropriate errors are shown

Scenario: Greater than 7 days in a week
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for a full leave year'
	And the user enters '10' into the 'Number of days worked per week' input
	Then the error element should be shown, indicating that there is a problem
	And the error should say that there are only 7 days in a week

Scenario: DayOfMonthGreaterThan31
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for someone starting part way through a leave year'
	And the user enters the date '32-01-2024' as 'the employment start date'
	Then the error element should be shown, indicating that there is a problem
	And the error should say that you must answer this question

Scenario: LeaveYearStartDateAfterEmploymentStartDate
	Given the user is on the Base page
	When the user selects 'days worked per week'
	And the user selects 'for someone starting part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment start date'
	And the user enters the date '01-06-2024' as 'the leave year start date'
	Then the error element should be shown, indicating that there is a problem
	And the error should say that the leave year start date must be earlier than your employment start date of '01 January 2024'

