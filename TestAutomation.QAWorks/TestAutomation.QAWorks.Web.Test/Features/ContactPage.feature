Feature: ContactPage
	In order to find out more about QAWorks exiting services
	As a user
	I want a working contact us page

@001
@Chrome
Scenario Outline: Valid Submission Using Chrome
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value       |
| Name     | '<Name>'    |
| Email    | '<Email>'   |
| Messsage | '<Message>' |
Then Information should be Submitted Successfully

Examples: 
| Name     | Email                | Message                                   |
| j.Bloggs | j.Bloggs@qaworks.com | please contact me I want to find out more |

@002 
Scenario: Valid Submission Using FireFox
Given I'm using FireFox
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value                |
| Name     | j.Bloggs             |
| Email    | j.Bloggs@qaworks.com |
| Messsage | please contact me    |
Then Information should be Submitted Successfully


@002 
Scenario: Valid Submission Using FireFox
Given I'm using FireFox
Given I'm on the QAWorks website
When I contact QAWorks with the following information
| Field    | Value                |
| Name     | j.Bloggs             |
| Email    | j.Bloggs@qaworks.com |
| Messsage | please contact me    |
Then Information should be Submitted Successfully


