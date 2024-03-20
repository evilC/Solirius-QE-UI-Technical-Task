Feature: Annualised hours
	Verify correct answers for Annualised hours

Scenario: Annualised hours for a full year
	Given the user is on the Base page
	When the user selects 'annualised hours'
	And the user selects 'for a full leave year'
	Then the holiday entitlement should read '5.6' weeks

Scenario: Annualised hours starting part way
	Given the user is on the Base page
	When the user selects 'annualised hours'
	And the user selects 'for someone starting part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment start date'
	And the user enters the date '01-06-2023' as 'the leave year start date'
	Then the holiday entitlement should read '2.34' weeks

Scenario: Annualised hours leaving part way
	Given the user is on the Base page
	When the user selects 'annualised hours'
	And the user selects 'for someone leaving part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment end date'
	And the user enters the date '01-06-2023' as 'the leave year start date'
	Then the holiday entitlement should read '3.29' weeks

Scenario: Annualised hours starting and leaving part way
	Given the user is on the Base page
	When the user selects 'annualised hours'
	And the user selects 'for someone starting and leaving part way through a leave year'
	And the user enters the date '01-01-2024' as 'the employment start date'
	And the user enters the date '01-06-2024' as 'the employment end date'
	Then the holiday entitlement should read '2.35' weeks





