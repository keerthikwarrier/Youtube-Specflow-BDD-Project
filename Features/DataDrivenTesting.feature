Feature: DataDrivenTesting

Multiple ways of performing Data Driven Testinng are Pass the Test Data in Step Level or Examples level

#StepLevel
Scenario: Data Driven Testing - Search Because Its Interesting On Youtube 
	When Search for 'Because Its Interesting'
	Then Because Its Interesting channel should be displayed

#MorethanoneData
#When there's more than one test data or test case use Scenario Outline
Scenario Outline: Data Driven Testing - Search Multiple Channels On Youtube 
	When Search for <SearchChannel>
	Then Verify the Channel should be displayed <ChannelFound>

Examples:
| SearchChannel           | ChannelFound            |
| Because Its Interesting | Because Its Interesting |
| Simplilearn             | Simplilearn   |


#Using DataTables
Scenario Outline: Data Driven Testing Data Tables - Search Multiple Channels on Youtube
When Search the Channel on Youtube search
| ChannelSearch | ChannelFound |
| Simplilearn   | Simplilearn  |
Then Verify the search displays the Channel
| ChannelSearch | ChannelFound |
| Simplilearn   | Simplilearn  |


