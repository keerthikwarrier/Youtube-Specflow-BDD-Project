Feature: DataDrivenTesting

Multiple ways of performing Data Driven Testinng are Pass the Test Data in Step Level or Examples level

#StepLevel
Scenario: Data Driven Testing - Search Because Its Interesting On Youtube 
	When Go to Youtube 
	And Search for 'Because Its Interesting'
	Then Because Its Interesting channel should be displayed

#ExampleLevel
#When there's more than one test data or test case use Scenario Outline
Scenario: Data Driven Testing - Search Channels On Youtube 
	When Go to Youtube 
	And Search for <SearchChannel>
	Then Because Its Interesting channel should be displayed
Examples: 
| SearchChannel           |
| Because Its Interesting |

#WithoutExampleLevel
#When there's more than one test data or test case use Scenario Outline
Scenario Outline: Data Driven Testing - Search Multiple Channels On Youtube 
	When Go to Youtube 
	And Search for <SearchChannel>
	Then Verify the Channel should be displayed
| SearchChannel           | ChannelFound            |
| Because Its Interesting | Latest from Because     |
| Simplilearn             | Latest from Simplilearn |