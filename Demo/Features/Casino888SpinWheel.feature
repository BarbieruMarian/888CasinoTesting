Feature: Casino888SpinWheel


@mytag
Scenario: Casino888SpinWheel
	Given I go to 888Casino Home Page
	And I type my authentication data as below
	| Username             | Password   |
	| Auto3k4yn			   | Ap123456!  | 

	Then I verify that the login succeeded
	And I open the "Trail of Treats" game
	Then I Switch to Demo Mode
	And I click the Spin Button