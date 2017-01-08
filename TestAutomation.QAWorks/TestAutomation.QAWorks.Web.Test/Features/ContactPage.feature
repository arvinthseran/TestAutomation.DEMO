@Chrome
Feature: ContactPage
	In order to find out more about QAWorks exiting services
	As a user
	I want a working contact us page

@003 
Scenario: Thank You Message is displayed after Successful Submission
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value                |
| Name     | j.Bloggs             |
| Email    | j.Bloggs@qaworks.com |
| Messsage | please contact me    |
Then Thank you message should be displayed

@004
Scenario Outline: Valid Submission Using Foreign Languages
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value     |
| Name     | <Name>    |
| Email    | <Email>   |
| Messsage | <Message> |
Then Information should be Submitted Successfully

Examples: 
| Name        | Email                   | Message                                                       |
| Albert Jêan | Albert.Jêan@qaworks.com | Myself Jêan, Souhaite en savoir plus sur les services QAWorks |
| 伟 张         | 伟.张@QQ.com              | 请联系我                                                          |

@005
Scenario: Can Not Submit without Name
Given I'm on the QAWorks website
When I accidentally leave Name field empty 
Then I should see following error Your name is required

@006
Scenario: Can Not Submit without Email
Given I'm on the QAWorks website
When I accidentally leave Email field empty 
Then I should see following error An Email address is required

@007
Scenario: Can Not Submit without Message
Given I'm on the QAWorks website
When I accidentally leave Message field empty 
Then I should see following error Please type your message

@008
Scenario: Warning message is displayed when I enter an Invalid Email address
Given I'm on the QAWorks website
When I accidentally enter an invalid email address
Then I should see following error Invalid Email Address

@009
Scenario: Can Not Submit with Invalid Email Address
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value             |
| Name     | j.Bloggs          |
| Email    | j.Bloggs          |
| Messsage | please contact me |
Then I should see following error Invalid Email Address

@010
Scenario: All Fields should be cleared after submission
Given I'm on the QAWorks website
When I contact QAWorks 
Then Information should be Submitted Successfully
And All fields should be cleared

@011
Scenario: Can Submit multiple email address
Given I'm on the QAWorks website
When I contact QAWorks using multiple email address
Then Information should be Submitted Successfully
And All fields should be cleared
