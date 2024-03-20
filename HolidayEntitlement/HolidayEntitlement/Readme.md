# About
A sample test framework which tests the Gov.uk holiday entitlement page

## Setup instructions
* Install `Specflow for Visual Studio` (Can be done via extensions GUI)
* Install LivingDoc CLI tool using  
    `dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`
* Further dependencies (SpecFlow, Playwright, NUnit, Fluent Assertions etc) are handled via NuGet, so installation should be automatic

## Running tests
### Via the GUI
Use the visual studio Test Explorer
### Via command-line
`dotnet test`

## Report generation
1. Run `gendoc.bat` in the root folder to generate SpecFlow LivingDoc  
  ( Or equivalent command, eg `livingdoc test-assembly bin\Debug\net6.0\HolidayEntitlement.dll -t bin\Debug\net6.0\TestExecution.json`)
2. Open `LivingDoc.html` in a browser to view

## ToDo

* Check General page layout? eg Menu at top, logos present, titles etc

* More Tests for invalid form fill
	- Start Date after end date
	- Non-numeric input
	- More than 24 hours in a day
	- More than 7 days in a week

* Hide Cookies notification?

* Finish assertion correct contents of "Your Answers" section
	- Check "Change" works

* Check "Start Again" works

* Cross-browser testing


