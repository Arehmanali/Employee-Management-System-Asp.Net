

**Employee Management System**

**Software Requirements Specification**

Software Engineering Project

**Version 1.0**

**Group Id:**

SE-PID-09

**Group Members:**

Rehman Ali

(2018-CS-17)

(2018-CS-20)

(2018-CS-42)

Daniyal Iqbal

Zargham Asim

**Supervisor Name:** Ms. Taliah Tajammal

Department of Computer Science

University of Engineering and Technology Lahore

1 **|** Software Requirement Specification





**Table of Contents**

***1***

**2**

**3**

**INTRODUCTION**

**3**

1.1

1.2

1.3

SCOPE

3

3

3

GLOSSARY

TECHNOLOGIES TO BE USED

**GENERAL DESCRIPTION**

**4**

2.1

2.2

2.3

USER CHARACTERISTICS

4

4

4

GENERAL CONSTRAINTS

ASSUMPTIONS & DEPENDENCIES

**SPECIFIC REQUIREMENTS**

**5**

3.1

3.2

EXTERNAL INTERFACE REQUIREMENTS:

5

*5*

7

*3.1.1*

*User Interfaces*

FUNCTIONAL REQUIREMENTS

*3.2.1*

*3.2.2*

*Admin*

*Employee*

*7*

*7*

8

3.3

3.4

USE CASES

NON-FUNCTIONAL REQUIREMENTS

17

**4**

**5**

**METHODOLOGY**

**17**

4.1

4.2

4.3

ADOPTED METHODOLOGY

17

18

18

DIAGRAM OF METHODOLOGY

REASON OF CHOOSING METHODOLOGY

**PROJECT WORK PLAN**

**19**

2 **|** Software Requirement Specification





***1* Introduction**

The introduction of the System Requirement Specification (SRS) gives us the complete overview

of the scope, summary and technologies to be used. The main purpose of the document is to

recognize, examine and complete awareness of Employee Management System (EMS) in detail.

It summarizes the targeted audience project, system's user interface, functional and non-

functional requirements and needs.

***1.1 Scope***

Basically, this SRS is associated with all the features that make Employee Management System

live. This project is being developed in order to ensure smooth and effective evaluation of

functions provided for the benefits of an organization. From administrative to non–administrative

management in an organization, this project provides a complete set of well-ordered solutions to

all the problems. This SRS is not only related to a specific module or tool of this project but it

also identifies the entire Employee Management System.

***1.2 Glossary***

Term

Stakeholder

Definition

Any person with an interest in the project who is not a

developer.

User

All system actors e.g. Admin, Employee.

Functionalities of the system (View, Add, Delete,

Update/Edit)

Manage

***1.3 Technologies to be used***

**Technology**

**Description**

**Microsoft Project**

**Professional**

Microsoft Project is a [project](http://en.wikipedia.org/wiki/Project_management_software)[ ](http://en.wikipedia.org/wiki/Project_management_software)[management](http://en.wikipedia.org/wiki/Project_management_software)[ ](http://en.wikipedia.org/wiki/Project_management_software)[software](http://en.wikipedia.org/wiki/Project_management_software)[ ](http://en.wikipedia.org/wiki/Project_management_software)program,

developed and sold by [Microsoft](http://en.wikipedia.org/wiki/Microsoft), which is designed to assist

a [project](http://en.wikipedia.org/wiki/Project_manager)[ ](http://en.wikipedia.org/wiki/Project_manager)[manager](http://en.wikipedia.org/wiki/Project_manager)[ ](http://en.wikipedia.org/wiki/Project_manager)in developing a [plan](http://en.wikipedia.org/wiki/Plan), assigning [resources](http://en.wikipedia.org/wiki/Resource_\(project_management\))[ ](http://en.wikipedia.org/wiki/Resource_\(project_management\))to

tasks, tracking progress, managing the [budget](http://en.wikipedia.org/wiki/Budget), and analyzing

workloads.

**Pencil**

Pencil is a toll used for people to create mockups of their

applications and a visual layout of design process. It is easily

accessible as a desktop application.

3 **|** Software Requirement Specification





**Visual Studio/**

It is used to develop computer programs as well as websites and

**Visual Studio Code** apps. It combines the simplicity of a source code editor with

powerful developer tooling, like IntelliSense code completion and

debugging

**SQL Server**

**Management**

**Studio**

SSMS provides tools to configure, monitor, and administer

instances of SQL Server and databases.

**2 General Description**

***2.1 User Characteristics***

The users of the system are:

· Admin

· Employees

The users of the system should know the English language basics and basic knowledge of

computer and internet. The separate characteristics of each user are given below:

**Admin:**

Admin should know how to tackle and solve small problems including every error and

power failures for the maintenance and smooth running of the system. As the characteristics of

admin are concerned, in the aspect of employee, the admin will add a new hired employee and

edit/update and delete an existing employee. Admin can calculate the salary of employee i.e

calculate loan, dues and allowance etc., manage attendance/leaves and manage work history and

promotion of employee.

**Employee:**

The employee can manage its own database and can view salary, pay slip, allowance and

attendances/leaves.

***2.2 General Constraints***

This project focusses on one branch of organization at a time and there is no functionality

for other branches of organization to be interlinked.

***2.3 Assumptions & Dependencies***

There are many factors that affect the requirements specified in the SRS. These include:

\1. Every user of this system should have the good internet speed of 20k or above.

\2. To avoid the unauthorized access to this system, the login and passwords will be kept

confidential keeping in consideration the security of organization.

\3. Ensure the reliability all the time such that any error in the system or system failure does

not affect the stored data of the organization.

4 **|** Software Requirement Specification





**3 Specific Requirements**

***3.1 External Interface Requirements:***

**3.1.1 User Interfaces**

Login Page

**T1:** As Admin, I shall be able to select my role as admin and login the system.

**T2:** As Employee, I shall be able to choose my role as employee and login the system.

Create New User Page

5 **|** Software Requirement Specification





**T1:** As an admin, I can add new employee and assign an I'd and password to that specific employee.

Employee’s Record

**T1:** As an admin, I shall be able to brows the image of employee and select the image.

**T2:** As an admin, I can save the record of employees.

Employee’s Attendance:

6 **|** Software Requirement Specification





**T1:** As an admin, I can add the attendance of employee. So, it can be seen in future that specific

employee was present in specific day or not.

Employee Leave Page

**T1:** As an admin, I can accept employee leave.

**T2:** As an admin, I can reject employee leave.

Rest of pages are not included because they have same format.

7 **|** Software Requirement Specification





***3.2 Functional Requirements***

**3.2.1 Admin**

\1. Admin shall be able to login.

\2. Admin shall be able to manage employee.

\3. Admin shall be able to manage working history of employee.

\4. Admin shall be able to manage promotion of employee.

\5. Admin shall be able to manage attendances of employee.

\6. Admin shall be able to manage leaves of employee

\7. Admin shall be able to manage salary, loan and allowances of employee.

\8. Admin shall be able to search the specific employee.

**3.2.2 Employee**

\9. Employee shall be able to login.

\10. Employee shall review their information.

\11. Employee shall be able to manage their personal information.

\12. Employee shall be able to see their salary.

\13. Employee shall be able to see their attendance.

\14. Employee shall be able to request for a leave.

***3.3 Use Cases***

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Login**

1

1

**Description:** This use case describes how users gain access to the employee management

system through the login process.

**Pre-Conditions:** Load the “Login” screen.

**Normal Flow**

\1. User browse to “Login” page.

\2. User enter the username and password in the returning user section.

\3. System validates the username and password (successfully).

\4. System provides the all the required information based on the user class.

**Alternative Flow**

3a. There is a problem in the data provided; username and password not valid.

−

System determines that the username and password is incorrect and ask the user to

try again.

**Post Conditions:**

\- User is either logged in or failed to login and is appropriately informed.

**Open issues:** If the user is not registered. One will have wait for one day to process complaint

to the administrator.

**Authority:** Admin, employee

**Use Case Title**

**Manage Employee**

8 **|** Software Requirement Specification





**Use Case Id**

**Requirement Id**

2

2

**Description:** This use case describes how admin manage the records of employee using the

system.

**Pre-Conditions:**

\1. User should be logged in as admin.

\2. Admin must be in “Manage Employee” page.

\3. Database should be available in online mode.

\4. No duplicates of employee in the database.

\5. An appropriate non-empty database should be present and also be ready for adding the

new records.

\6. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Employee” page.

\2. System opts for a form to be filled and display a table that contain list of employees

already added in the system and database.

\3. **Add**: user provides the all the information required and opts to complete the operation.

\4. **Add**: system after confirmation adds the new record.

\5. **Delete**: user searches the required data in the table and delete it.

\6. **Delete**: System after confirmation deletes the data.

\7. **Edit**: user searches the required data in the table and modify it.

\8. **Edit**: user edits the form fields and opts to complete the operation.

\9. **Edit**: System after confirmation update the records.

**Alternative Flow**

3a. There is a problem in the data provided; some data needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- A new record added, edited or deleted in database and system and user is

appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Manage Working History of Employee**

3

3

**Description:** This use case describes how admin manage the working history of employee

using the system.

**Pre-Conditions:**

\1. User should be logged in as admin.

9 **|** Software Requirement Specification





\2. Admin must be in “Manage Working History” page.

\3. Database should be available in online mode.

\4. Employee record must be present in database to add his/her working history.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Working History” page.

\2. System opts for a form to be filled and display a table that contain list of employees

already added in the system and database.

\3. **Add**: user provides the all the information required and opts to complete the operation.

\4. **Add**: system after confirmation adds the working history of employee.

\5. **Delete**: user searches the required employee working history in the table and delete it.

\6. **Delete**: system after confirmation deletes the data.

\7. **Edit**: user searches the required data in the table and modify it.

\8. **Edit**: user edits the form fields and opts to complete the operation.

\9. **Edit**: System after confirmation update the working history of respected employee.

**Alternative Flow**

3a. There is a problem in the data provided; some data needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- Working history of already existing employees must be added, edited or deleted in

database and system and user is appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Manage Promotion of Employee**

4

4

**Description:** This use case describes how admin manages the promotion of employee using

the system.

**Pre-Conditions:**

\1. Admin must be logged in before marking employee attendance.

\2. Admin must be in “Manage Promotions” page.

\3. Database must be available in online mode.

\4. Employee record must be present in database to promote him/her.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Promotion” page.

\2. System opts for a form to be filled and display a table that contain list of employees

already added in the system and database.

10 **|** Software Requirement Specification





\3. User select the employee from the table and promote him/her.

\4. System validate the changes and update the table and database.

**Alternative Flow**

3a. There is a problem in the data provided; employee didn’t exist in the database.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- Promotion of already existing employees occurs or failed and user is appropriately

informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user employee is not present?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Manage Attendance of Employee**

5

5

**Description:** This use case describes how admin manages the attendance of employee using

the system.

**Pre-Conditions:**

\1. Admin must be logged in before marking employee attendance.

\2. Admin must be in “Manage Attendance” page.

\3. Employee records must be displayed on screen to mark attendance.

\4. Database must be available in online mode.

\5. All must-required information should be present.

**Normal Flow**

\1. user go to “Manage Attendance” Page.

\2. User fill the date and category field to mark the attendance.

\3. User mark the attendance as present or leave from the table of employees.

\4. System after confirmation add the attendance of the employee.

**Alternative Flow**

2a. There is a problem in the data provided; some data needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- Attendance of employee marked as present/absent or failed and user is

appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Manage Leaves of Employee**

11 **|** Software Requirement Specification





**Use Case Id**

**Requirement Id**

6

6

**Description:** This use case describes how admin manages the leaves of employee using the

system.

**Pre-Conditions:**

\1. Admin must be logged in before accepting the leave of employee.

\2. Admin must be in “Manage leaves” page.

\3. Database must be available in online mode.

\4. Employee record must be present in database to accept the leaves.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Leaves” page.

\2. System opts for a form to be filled.

\3. User fill the form and accept the request of leave.

\4. System validate the changes and update the table and database.

**Alternative Flow**

3a. There is a problem in the data provided; some field needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- User accepts the leaves of employee or failed and user is appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user employee is not present?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Manage Salary of Employee**

7

7

**Description:** This use case describes how admin manages the salary loans and allowances of

employee using the system.

**Pre-Conditions:**

\1. User should be logged in as admin.

\2. Admin must be in “Manage Salary” page.

\3. Database should be available in online mode.

\4. Employee record must be present in database to manage the salary.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Salary” page.

\2. System opts for a form to be filled and display a table that contain list of employees

already added in the system and database.

\3. **Add**: user provides the all the information required and opts to complete the operation.

\4. **Add**: system after confirmation adds the salary of employee.

12 **|** Software Requirement Specification





\5. **Delete**: user searches the required employee salary in the table and delete it.

\6. **Delete**: system after confirmation deletes the data.

\7. **Edit**: user searches the required data in the table and modify it.

\8. **Edit**: user edits the form fields and opts to complete the operation.

\9. **Edit**: System after confirmation update the salary of respected employee.

**Alternative Flow**

3a. There is a problem in the data provided; some data needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- Salary of already existing/new employees must be added, edited or deleted in

database and system and user is appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Search the Employee**

8

8

**Description:** This use case describes how admin search the specific employee using the

system.

**Pre-Conditions:**

\1. Admin must be logged in before marking employee attendance.

\2. Admin must be in “Search Employee” page.

\3. Database must be available in online mode.

\4. Employee record must be present in database.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Search Employee” page.

\2. System opts for Employee Id of employees that already added in the system and

database.

\3. User can search the specific employee from the table.

**Alternative Flow**

3a. There is a problem in the data provided; employee didn’t exist in the database.

\- User must add employee first and then search the employee.

**Post Conditions:**

\- Search the specific employee and see its information.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user employee is not present?

\3. What if there is no connection with database?

\4. What if the database crashes?

13 **|** Software Requirement Specification





**Authority:** Admin

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Login**

9

9

**Description:** This use case describes how users gain access to the employee management

system through the login process.

**Pre-Conditions:** Load the “Login” screen.

**Normal Flow**

\1. User browse to “Login” page.

\2. User enter the username and password in the returning user section.

\3. System validates the username and password (successfully).

\4. System provides the all the required information based on the user class.

**Alternative Flow**

3a. There is a problem in the data provided; username and password not valid.

−

System determines that the username and password is incorrect and ask the user to

try again.

**Post Conditions:**

\- User is either logged in or failed to login and is appropriately informed.

**Open issues:** If the user is not registered. One will have wait for one day to process complaint

to the administrator.

**Authority:** Admin, employee

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Review the Information**

10

10

**Description:** This use case describes employee review their records using the system.

**Pre-Conditions:**

\1. User should be logged in as employee.

\2. Employee must be in “Review Records” page.

\3. Database should be available in online mode.

\4. No duplicates of employee in the database.

\5. All information should be present.

**Normal Flow**

\1. User gets to the “Review Records” page.

\2. User can review their records that already added in the system and database.

**Alternative Flow**

2a. There is a problem in the data provided; employee didn’t exist in the database.

−

User must be added before and then he/she can review their information.

**Post Conditions:**

\- User can review their information.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

14 **|** Software Requirement Specification





\4. What if the database crashes?

**Authority:** Employee

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Manage Information**

11

11

**Description:** This use case describes how employee manage their record using the system.

**Pre-Conditions:**

\1. User should be logged in as employee.

\2. Employee must be in “Manage Information” page.

\3. Database should be available in online mode.

\4. No duplicates of employee in the database.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Manage Information” page.

\2. System opts for a form to be filled and display a table that contain list of employee

information already added in the system and database.

\3. **Add**: user provides the all the information required and opts to complete the operation.

\4. **Add**: system after confirmation adds the new record.

\5. **Delete**: user searches the required data in the table and delete it.

\6. **Delete**: System after confirmation deletes the data.

\7. **Edit**: user searches the required data in the table and modify it.

\8. **Edit**: user edits the form fields and opts to complete the operation.

\9. **Edit**: System after confirmation update the records.

**Alternative Flow**

3a. There is a problem in the data provided; some data needs to be correct.

−

User checks the fields and corrects the errors. User continues from the same form.

**Post Conditions:**

\- A new record added, edited or deleted in database and system and user is

appropriately informed.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Employee

**Use Case Title**

**Use Case Id**

**Requirement Id**

**View Salary**

12

12

**Description:** This use case describes how employee can view their salary using the system.

**Pre-Conditions:**

\1. User should be logged in as employee.

15 **|** Software Requirement Specification





\2. Employee must be in “View Salary” page.

\3. Database should be available in online mode.

\4. Employee record must be present in database to view the salary.

\5. All must-required information should be present.

**Normal Flow**

\1. User gets to the “View Salary” page.

\2. User can view their salary.

**Alternative Flow**

2a. There is a problem; employee didn’t exist in the database.

**Post Conditions:**

\- Employee can view their salary.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Employee

**Use Case Title**

**Use Case Id**

**Requirement Id**

**View Attendance**

13

13

**Description:** This use case describes how employee can see the attendance using the system.

**Pre-Conditions:**

\1. Employee must be in “View Attendance” page.

\2. Database must be available in online mode.

\3. All must-required information should be present.

**Normal Flow**

\1. User go to “View Attendance” Page.

\2. User can see the attendance as present or leave.

**Alternative Flow**

2a. There is a problem; employee didn’t exist in the database.

**Post Conditions:**

\- Employee can view their attendance as he/she present or leave.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user record is not available?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Employee

**Use Case Title**

**Use Case Id**

**Requirement Id**

**Can request for leaves**

14

14

**Description:** This use case describes employee request for leaves using the system.

**Pre-Conditions:**

16 **|** Software Requirement Specification





\1. Employee must be in “Request for leaves” page.

\2. Database must be available in online mode.

\3. Employee record must be present in database for requesting.

\4. All must-required information should be present.

**Normal Flow**

\1. User gets to the “Request for leaves” page.

\2. System opts for a form to be filled.

\3. User fill the form and request for leave.

\4. System validate the changes and update the table and database.

**Alternative Flow**

2a. There is a problem; employee didn’t exist in the database.

**Post Conditions:**

\- Admin accepts the leaves of employee or not.

**Open issues:**

\1. What if the system displays an error message?

\2. What if user employee is not present?

\3. What if there is no connection with database?

\4. What if the database crashes?

**Authority:** Employee

***3.4 Non-Functional Requirements***

· Performance

Ø Huge Data

\- System will deal with huge data and doesn’t crash for safety.

Ø Reliability and Efficiency

\- it gives the same repeated result under the same conditions.

Ø Maintenance

· Usability

Ø User Friendly Interface

\- System is easy to use and does not need any further training.

Ø Managing Accounts

\- System has requirements to login. When user is logged into the

system then it provides the functionalities related to it.

**4 Methodology**

***4.1 Adopted Methodology***

The adopted methodology for this project is SCRUM. SCRUM is agile methodology. Scrum

principle are consistent with Agile Manifesto and use to guide development activities within the

process that incorporates with framework activities. Within each framework activity, work task

occurs within the process patterns call sprints. SCRUM emphasize the use of set of software

17 **|** Software Requirement Specification





process patterns and define a set of development actions like BACKLOG, SPRINT, SCRUM

MEETING, DEMOS.

***4.2 Diagram of Methodology***

***4.3 Reason of Choosing Methodology***

· It is flexible and adaptable nature throughout the entire process.

· The Daily Scrum is a short meeting that ensure the teams are in the habit of

communicating, solving problems, and creating ideas together.

· It focuses on team work.

· Throughout the SPRINTS, there is always visibility on the team’s tasks and the progress

of each task. In addition, everyone uses the same terminology and understands their role

and responsibilities.

**5 Project Work Plan**

18 **|** Software Requirement Specification





19 **|** Software Requirement Specification





20 **|** Software Requirement Specification





21 **|** Software Requirement Specification





22 **|** Software Requirement Specification





23 **|** Software Requirement Specification





24 **|** Software Requirement Specification

