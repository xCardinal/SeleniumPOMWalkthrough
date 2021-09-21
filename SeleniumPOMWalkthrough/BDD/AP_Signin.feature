Feature: AP_Signin
	In order to be able to buy items
	As a registered user of the automation practice website
	I want to be able to sign in to my account

@Login
Scenario: Invalid password - too short
	Given I am on the signin page
	And I have entered the email "testing@snailmail.com"
	And I have entered the password <passwords>
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid password."
	Examples: 
	| passwords |
	| four      |
	| 1234      |
	| nish      |

@Login
Scenario: Invalid email
	Given I am on the signin page
	And I have entered the email "blabla.com"
	And I have entered the password "nish"
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid email address."

@Login
Scenario: Forgot Password
Given I am on the signin page
When I click the forgot your password link
Then I will got to a form to reset my password

@Login 
Scenario: Invalid email - using Specflow Assist
Given I am on the signin page
And I have the following credentials

| Email    | Password |
| test.com | nish     |

When I enter these credentials 
When I click the sign in button
Then I should see an alert containing the error message "Invalid email address."