Feature: SearchOnYoutube


Scenario: Search Because Its Interesting On Youtube
	Given Open the browser
	When Go to Youtube 
	And Search Because Its Interesting
	Then Because Its Interesting channel should be displayed

Scenario: Verify the Subsription without Signin
	When Go to Youtube 
	And Go to Subsriptions Tab in Youtube 
	Then Signin button should be displayed
	
