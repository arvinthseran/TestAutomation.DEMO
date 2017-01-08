Feature: MultipleBrowser
	In order to make sure QAWorks Contact Page works with different Browsers 
	As a Techinical Test Engineer
	I want a valid submission through contact page

@001
@Chrome
Scenario Outline: Valid Submission Using Chrome
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value     |
| Name     | <Name>    |
| Email    | <Email>   |
| Messsage | <Message> |
Then Information should be Submitted Successfully
And All fields should be cleared

Examples: 
| Name     | Email                | Message                                   |
| j.Bloggs | j.Bloggs@qaworks.com | please contact me I want to find out more |

@002
@FireFox
Scenario: Valid Submission Using FireFox
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value                |
| Name     | j.Bloggs             |
| Email    | j.Bloggs@qaworks.com |
| Messsage | please contact me    |
Then Information should be Submitted Successfully
And All fields should be cleared