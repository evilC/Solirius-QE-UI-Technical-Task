Feature: Compressed hours
	Verify correct answers for Compressed hours

Scenario: Compressed hours for a full year
	Given the user is on the Base page
	When the user selects 'compressed hours'
	And the user selects 'for a full leave year'
	And the user enters '5' into the 'Number of hours worked per week' input
	And the user enters '5' into the 'Number of days worked per week' input
	Then the holiday entitlement should read '28' hours, '0' minutes, rather '1' hours, '0' minutes
