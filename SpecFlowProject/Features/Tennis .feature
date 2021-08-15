Feature: Tennis
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: 0:0 
	Given the first score is 0
	And the second score is 0
	When get the score display
	Then the result should be Love All

Scenario: 1:0 
	Given the first score is 1
	And the second score is 0
	When get the score display
	Then the result should be Fifteen Love

Scenario: 2:0 
	Given the first score is 2
	And the second score is 0
	When get the score display
	Then the result should be Thirty Love

Scenario: 3:0 
	Given the first score is 3
	And the second score is 0
	When get the score display
	Then the result should be Forty Love

Scenario: 0:1 
	Given the first score is 0
	And the second score is 1
	When get the score display
	Then the result should be Love Fifteen

Scenario: 0:2 
	Given the first score is 0
	And the second score is 2
	When get the score display
	Then the result should be Love Thirty

Scenario: 0:3 
	Given the first score is 0
	And the second score is 3
	When get the score display
	Then the result should be Love Forty

Scenario: 1:1 
	Given the first score is 1
	And the second score is 1
	When get the score display
	Then the result should be Fifteen All

Scenario: 2:2 
	Given the first score is 2
	And the second score is 2
	When get the score display
	Then the result should be Thirty All

Scenario: 3:3 
	Given the first score is 3
	And the second score is 3
	When get the score display
	Then the result should be Deuce

Scenario: 4:4 
	Given the first score is 4
	And the second score is 4
	When get the score display
	Then the result should be Deuce

Scenario: 4:3
	Given the first score is 4
	And the second score is 3
	When get the score display
	Then the result should be Player A Adv

Scenario: 5:3 
	Given the first score is 5
	And the second score is 3
	When get the score display
	Then the result should be Player A Win

Scenario: 4:5
	Given the first score is 3
	And the second score is 4
	When get the score display
	Then the result should be Player B Adv

Scenario: 3:5 
	Given the first score is 3
	And the second score is 5
	When get the score display
	Then the result should be Player B Win
