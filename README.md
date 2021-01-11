# Employee Management System


1.
# Introduction

The introduction of the System Requirement Specification (SRS) gives us the complete overview of the scope, summary and technologies to be used. The main purpose of the document is to recognize, examine and complete awareness of Employee Management System (EMS) in detail. It summarizes the targeted audience project, system&#39;s user interface, functional and non-functional requirements and needs.

  1.
## Scope

Basically, this SRS is associated with all the features that make Employee Management System live. This project is being developed in order to ensure smooth and effective evaluation of functions provided for the benefits of an organization. From administrative to non–administrative management in an organization, this project provides a complete set of well-ordered solutions to all the problems. This SRS is not only related to a specific module or tool of this project but it also identifies the entire Employee Management System.

  1.
## Glossary

| Term | Definition |
| --- | --- |
| Stakeholder | Any person with an interest in the project who is not a developer. |
| User | All system actors e.g. Admin, Employee. |
| Manage | Functionalities of the system (View, Add, Delete, Update/Edit) |

  1.
## Technologies to be used

| Technology | Description |
| --- | --- |
| Microsoft Project Professional | Microsoft Project is a [project management software](http://en.wikipedia.org/wiki/Project_management_software) program, developed and sold by [Microsoft](http://en.wikipedia.org/wiki/Microsoft), which is designed to assist a [project manager](http://en.wikipedia.org/wiki/Project_manager) in developing a [plan](http://en.wikipedia.org/wiki/Plan), assigning [resources](http://en.wikipedia.org/wiki/Resource_(project_management)) to tasks, tracking progress, managing the [budget](http://en.wikipedia.org/wiki/Budget), and analyzing workloads. |
| Pencil | Pencil is a toll used for people to create mockups of their applications and a visual layout of design process. It is easily accessible as a desktop application. |
| Visual Studio/ Visual Studio Code | It is used to develop computer programs as well as websites and apps. It combines the simplicity of a source code editor with powerful developer tooling, like IntelliSense code completion and debugging |
| SQL Server Management Studio | SSMS provides tools to configure, monitor, and administer instances of SQL Server and databases. |

1.
# General Description

  1.
## User Characteristics

The users of the system are:

- Admin
- Employees

The users of the system should know the English language basics and basic knowledge of computer and internet. The separate characteristics of each user are given below:

**Admin:**

Admin should know how to tackle and solve small problems including every error and power failures for the maintenance and smooth running of the system. As the characteristics of admin are concerned, in the aspect of employee, the admin will add a new hired employee and edit/update and delete an existing employee. Admin can calculate the salary of employee i.e calculate loan, dues and allowance etc., manage attendance/leaves and manage work history and promotion of employee.

**Employee:**

The employee can manage its own database and can view salary, pay slip, allowance and attendances/leaves.

  1.
## General Constraints

This project focusses on one branch of organization at a time and there is no functionality for other branches of organization to be interlinked.

  1.
## Assumptions &amp; Dependencies

There are many factors that affect the requirements specified in the SRS. These include:

1. Every user of this system should have the good internet speed of 20k or above.
2. To avoid the unauthorized access to this system, the login and passwords will be kept confidential keeping in consideration the security of organization.
3. Ensure the reliability all the time such that any error in the system or system failure does not affect the stored data of the organization.

1.
# Specific Requirements

  1.
## External Interface Requirements:

    1.
### User Interfaces

Login Page

![](RackMultipart20210111-4-12qutev_html_7e8ee81d07f0df4a.png)

**T1**** :** As Admin, I shall be able to select my role as admin and login the system.

**T2:** As Employee, I shall be able to choose my role as employee and login the system.

Employee&#39;s Record

![](RackMultipart20210111-4-12qutev_html_41ab7f021b650534.png)

**T1:** As an admin, I shall be able to brows the image of employee and select the image.

**T2:** As an admin, I can save the record of employees.

Employee&#39;s Attendance:

![](RackMultipart20210111-4-12qutev_html_63eb2ca793b7d860.jpg)

**T1:** As an admin, I can add the attendance of employee. So it can be seen in future that specific employee was present in specific day or not.

Employee Leave Page

![](RackMultipart20210111-4-12qutev_html_62d567607d6ed4af.jpg)

**T1:** As an admin, I can accept employee leave.

**T2:** As an admin, I can reject employee leave.

Forgot Password Page

![](RackMultipart20210111-4-12qutev_html_96e3474b4fd11f91.jpg)

**T1:** As an admin, I can add new employee and assign an I&#39;d and password to that specific employee.

Rest of pages are not included because they have same format.

  1.
## Functional Requirements

    1.
### Admin:

1. Admin shall be able to login.
2. Admin shall be able to manage employee.
3. Admin shall be able to manage working history of employee.
4. Admin shall be able to manage promotion of employee.
5. Admin shall be able to manage attendances of employee.
6. Admin shall be able to manage leaves of employee
7. Admin shall be able to manage salary, loan and allowances of employee.
8. Admin shall be able to search the specific employee.

    1.
### Employee

1. Employee shall be able to login.
2. Employee shall review their information.
3. Employee shall be able to Manage their personal information.
4. Employee shall be able to see their salary.
5. Employee shall be able to see their attendance.
6. Employee shall be able to request for a leave.

  1.
## Use Cases:

| **Use Case Title** | **Login** |
| --- | --- |
| **Use Case Id** | 1 |
| **Requirement Id** | 1 |
| **Description:** This use case describes how users gain access to the employee management system through the login process. |
| **Pre-Conditions:** Load the &quot;Login&quot; screen. |
| **Normal Flow** |
|
1. User browse to &quot;Login&quot; page.
 |
|
1. User enter the username and password in the returning user section.
 |
|
1. System validates the username and password (successfully).
 |
|
1. System provides the all the required information based on the user class.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; username and password not valid.

- System determines that the username and password is incorrect and ask the user to try again.
 |
| **Post Conditions:**

- User is either logged in or failed to login and is appropriately informed.
 |
| **Open issues:** If the user is not registered. One will have wait for one day to process complaint to the administrator.
 |
| **Authority:** Admin, employee |

| **Use Case Title** | **Manage Employee** |
| --- | --- |
| **Use Case Id** | 2 |
| **Requirement Id** | 2 |
| **Description:** This use case describes how admin manage the records of employee using the system. |
| **Pre-Conditions:**
1. User should be logged in as admin.
2. Admin must be in &quot;Manage Employee&quot; page.
3. Database should be available in online mode.
4. No duplicates of employee in the database.
5. An appropriate non-empty database should be present and also be ready for adding the new records.
6. All must-required information should be present.
 |
| **Normal Flow** |
|
1. User gets to the &quot;Manage Employee&quot; page.
 |
|
1. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.
 |
|
1. **Add** : user provides the all the information required and opts to complete the operation.
 |
|
1. **Add** : system after confirmation adds the new record.
 |
|
1. **Delete** : user searches the required data in the table and delete it.
 |
|
1. **Delete** : System after confirmation deletes the data.
 |
|
1. **Edit** : user searches the required data in the table and modify it.
 |
|
1. **Edit** : user edits the form fields and opts to complete the operation.
 |
|
1. **Edit** : System after confirmation update the records.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; some data needs to be correct.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- A new record added, edited or deleted in database and system and user is appropriately informed.
 |
| **Open issues:**

  1. What if the system displays an error message?
  2. What if user record is not available?
  3. What if there is no connection with database?
  4. What if the database crashes?

 |
| **Authority:** Admin |

| **Use Case Title** | **Manage Working History of Employee** |
| --- | --- |
| **Use Case Id** | 3 |
| **Requirement Id** | 3 |
| **Description:** This use case describes how admin manage the working history of employee using the system. |
| **Pre-Conditions:**
1. User should be logged in as admin.
2. Admin must be in &quot;Manage Working History&quot; page.
3. Database should be available in online mode.
4. Employee record must be present in database to add his/her working history.
5. All must-required information should be present.
 |
| **Normal Flow** |
|
1. User gets to the &quot;Manage Working History&quot; page.
 |
|
1. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.
 |
|
1. **Add** : user provides the all the information required and opts to complete the operation.
 |
|
1. **Add** : system after confirmation adds the working history of employee.
 |
|
1. **Delete** : user searches the required employee working history in the table and delete it.
 |
|
1. **Delete** : system after confirmation deletes the data.
 |
|
1. **Edit** : user searches the required data in the table and modify it.
 |
|
1. **Edit** : user edits the form fields and opts to complete the operation.
 |
|
1. **Edit** : System after confirmation update the working history of respected employee.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; some data needs to be correct.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- Working history of already existing employees must be added, edited or deleted in database and system and user is appropriately informed.
 |
| **Open issues:**

  1. What if the system displays an error message?
  2. What if user record is not available?
  3. What if there is no connection with database?
  4. What if the database crashes?
 |
| **Authority:** Admin |

| **Use Case Title** | **Manage Promotion of Employee** |
| --- | --- |
| **Use Case Id** | 4 |
| **Requirement Id** | 4 |
| **Description:** This use case describes how admin manages the promotion of employee using the system. |
| **Pre-Conditions:**
1. Admin must be logged in before marking employee attendance.
2. Admin must be in &quot;Manage Promotions&quot; page.
3. Database must be available in online mode.
4. Employee record must be present in database to promote him/her.
5. All must-required information should be present.
 |
| **Normal Flow** |
|
1. User gets to the &quot;Manage Promotion&quot; page.
 |
|
1. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.
 |
|
1. User select the employee from the table and promote him/her.
 |
|
1. System validate the changes and update the table and database.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; employee didn&#39;t exist in the database.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- Promotion of already existing employees occurs or failed and user is appropriately informed.
 |
| **Open issues:**

  1. What if the system displays an error message?
  2. What if user employee is not present?
  3. What if there is no connection with database?
  4. What if the database crashes?
 |
| **Authority:** Admin |

| **Use Case Title** | **Manage Attendance of Employee** |
| --- | --- |
| **Use Case Id** | 5 |
| **Requirement Id** | 5 |
| **Description:** This use case describes how admin manages the attendance of employee using the system. |
| **Pre-Conditions:**
1. Admin must be logged in before marking employee attendance.
2. Admin must be in &quot;Manage Attendance&quot; page.
3. Employee records must be displayed on screen to mark attendance.
4. Database must be available in online mode.
5. All must-required information should be present.
 |
| **Normal Flow** |
|
1. user go to &quot;Manage Attendance&quot; Page.
 |
|
1. User fill the date and category field to mark the attendance.
 |
|
1. User mark the attendance as present or leave from the table of employees.
 |
|
1. System after confirmation add the attendance of the employee.
 |
| **Alternative Flow** |
| 2a. There is a problem in the data provided; some data needs to be correct.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- Attendance of employee marked as present/absent or failed and user is appropriately informed.
 |
| **Open issues:**

  1. What if the system displays an error message?
  2. What if user record is not available?
  3. What if there is no connection with database?
  4. What if the database crashes?

 |
| **Authority:** Admin |

| **Use Case Title** | **Manage Leaves of Employee** |
| --- | --- |
| **Use Case Id** | 6 |
| **Requirement Id** | 6 |
| **Description:** This use case describes how admin manages the leaves of employee using the system. |
| **Pre-Conditions:**
1. Admin must be logged in before accepting the leave of employee.
2. Admin must be in &quot;Manage leaves&quot; page.
3. Database must be available in online mode.
4. Employee record must be present in database to accept the leaves.
5. All must-required information should be present.
 |
| **Normal Flow** |
|
1. User gets to the &quot;Manage Leaves&quot; page.
 |
|
1. System opts for a form to be filled.
 |
|
1. User fill the form and accept the request of leave.
 |
|
1. System validate the changes and update the table and database.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; some field needs to be correct.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- User accepts the leaves of employee or failed and user is appropriately informed.
 |
| **Open issues:**
1. What if the system displays an error message?
2. What if user employee is not present?
3. What if there is no connection with database?
4. What if the database crashes?
 |
| **Authority:** Admin |

| **Use Case Title** | **Manage Salary of Employee** |
| --- | --- |
| **Use Case Id** | 7 |
| **Requirement Id** | 7 |
| **Description:** This use case describes how admin manages the salary loans and allowances of employee using the system. |
| **Pre-Conditions:**
1. User should be logged in as admin.
2. Admin must be in &quot;Manage Salary&quot; page.
3. Database should be available in online mode.
4. Employee record must be present in database to manage the salary.
5. All must-required information should be present.
 |
| **Normal Flow** |
|
1. User gets to the &quot;Manage Salary&quot; page.
 |
|
1. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.
 |
|
1. **Add** : user provides the all the information required and opts to complete the operation.
 |
|
1. **Add** : system after confirmation adds the salary of employee.
 |
|
1. **Delete** : user searches the required employee salary in the table and delete it.
 |
|
1. **Delete** : system after confirmation deletes the data.
 |
|
1. **Edit** : user searches the required data in the table and modify it.
 |
|
1. **Edit** : user edits the form fields and opts to complete the operation.
 |
|
1. **Edit** : System after confirmation update the salary of respected employee.
 |
| **Alternative Flow** |
| 3a. There is a problem in the data provided; some data needs to be correct.

- User checks the fields and corrects the errors. User continues from the same form.
 |
| **Post Conditions:**

- Salary of already existing/new employees must be added, edited or deleted in database and system and user is appropriately informed.
 |
| **Open issues:**

  1. What if the system displays an error message?
  2. What if user record is not available?
  3. What if there is no connection with database?
  4. What if the database crashes?
 |
| **Authority:** Admin |

  1.
## Non-Functional Requirements:

The project will be user-friendly, efficient and maintainable.

1.
# Methodology

  1.
## Adopted Methodology

The adopted methodology for this project is SCRUM. SCRUM is agile methodology. Scrum principle are consistent with Agile Manifesto and use to guide development activities within the process that incorporates with framework activities. Within each framework activity, work task occurs within the process patterns call sprints. SCRUM emphasize the use of set of software process patterns and define a set of development actions like BACKLOG, SPRINT, SCRUM MEETING, DEMOS.

  1.
## Diagram of Methodology

![](RackMultipart20210111-4-12qutev_html_6368ff8fc0e6ced5.png)

  1.
## Reason of Choosing Methodology

- It is flexible andadaptable nature throughout theentire process.
- The Daily Scrum is a short meeting that ensure the teams are in the habit of communicating, solving problems, and creating ideas together.
- It focuses on team work.
- Throughout the SPRINTS, there is always visibility on the team&#39;s tasks and the progress of each task. In addition, everyone uses the same terminology and understands their role and responsibilities.

1.
# Project Work Plan

\&lt;Provide Gantt chart of your final project, use MS Project to create work plan\&gt;

15 **|** Software Requirement Specification
