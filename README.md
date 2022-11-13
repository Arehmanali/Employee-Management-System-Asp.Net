# Employee Management System

## Introduction

The introduction of the Software Requirement Specification (SRS) gives us the complete overview of the scope, summary and technologies to be used. The main purpose of the document is to recognize, examine and complete awareness of Employee Management System (EMS) in detail. It  summarizes  the  targeted  audience  project,  system's  user  interface,  functional  and  non- functional requirements and needs of the project.

## Scope

Basically, this SRS is ashhsociated with all the features that make Employee Management System live.  This  project  is  being  developed  in  order  to  ensure  smooth  and the  effective  evaluation  of functions provided for the benefits of an organization. From administrative to non–administrative management in an organization, this project provides a complete set of well-ordered solutions to all the problems. This SRS is not only related to a specific module or tool of this project but it is also identifies the entire Employee Management System.

## Glossary

|Term|Definition|
| - | - |
|Stakeholder|Any person with an interest in the project who is not, a developer.|
|User|All system actors e.g. Admin, Employee.|
|Manage|Functionalities of the system (View, Add, Delete, Update/Edit)|

## Technologies to be used i

|**Technology**|**Description**|
| - | - |
|**Microsoft Project Professional**|Microsoft Project is a [project management software](http://en.wikipedia.org/wiki/Project_management_software) program, developed and sold by [Microsoft](http://en.wikipedia.org/wiki/Microsoft), which is designed to assist a [project manager](http://en.wikipedia.org/wiki/Project_manager) in developing a [plan](http://en.wikipedia.org/wiki/Plan), assigning [resources](http://en.wikipedia.org/wiki/Resource_\(project_management\)) to tasks, tracking progress, managing the [budget](http://en.wikipedia.org/wiki/Budget), and analyzing workloads.|
|**Pencil** |Pencil is a toll used for people to create mockups of their applications and a visual layout of design process. It is easily accessible as a desktop application.|
|**Visual Studio/ Visual Studio Code**|It is used to develop computer programs as well as websites and apps. It combines the simplicity of a source code editor with powerful developer tooling, like IntelliSense code completion and debugging|
|**SQL Server Management Studio**|SSMS provides tools to configure, monitor, and administer instances of SQL Server and databases.|
## General Description
### User Characteristics
The users of the system are:
- Admin
- Employees
The  users  of  the  system  should  know  the  English  language  basics  and  basic  knowledge  of computer and internet. The separate characteristics of each user are given below:

**Admin:**
Admin should know how to tackle and solve small problems including every error and power failures for the maintenance and smooth running of the system. As the characteristics of admin are concerned, in the aspect of employee, the admin will add a new hired employee and edit/update and delete an existing employee. Admin can calculate the salary of employee i.e calculate loan, dues and allowance etc., manage attendance/leaves and manage work history and promotion of employee.

**Me, 8Employee:**
The employee can manage its own database and can view salary, pay slip, allowance and attendances/leaves.

## General Constraints
This project focusses on one branch of organization at a time and there is no functionality for other branches of organization to be interlinked.

## Assumptions & Dependencies
There are many factors that affect the requirements specified in the SRS. These include:
1. Every user of this system should have the good internet speed of 20k or above.
2. To avoid the unauthorized access to this system, the login and passwords will be kept confidential keeping in consideration the security of organization.
3. Ensure the reliability all the time such that any error in the system or system failure does not affect the stored data of the organization.

## Specific Requirements

## External Interface Requirements

**User Interfaces:** 
Login Page

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.002.png?raw=true)

**T1:** As Admin, I shall be able to select my role as admin and login the system.
**T2:** As Employee, I shall be able to choose my role as employee and login the system.
**Create New User Page**

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.003.png?raw=true)

**T1:** As an admin, I can add new employee and assign an I'd and password to that specific employee. Employee’s Record

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.004.png?raw=true)

**T1:** As an admin, I shall be able to brows the image of the employee and select the image. **T2:** As an admin, I can save the record of employees.

Employee’s Attendance:
8
![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.005.png?raw=true)

**T1:** As an admin, I can add the attendance of employee. So, it can be seen in future that specific employee was present in specific day or not.

Employee Leave Page

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.006.png?raw=true)

**T1:** As an admin, I can accept empljjhhhhoyee leave. **T2:** As an admin, I can reject employee leave.

Rest of pages are not included because they have same format.

## Functional Requirements
**1. Admin**

1. Admin shall be able to login.
2. Admin shall be able to manage employee. 
3. Admin shall be able to manage working history of employee.
4. Admin shall be able to manage promotion of employee.
5. Admin shall be able to manage attendances of employee.
6. Admin shall be able to manage leaves of employee
7. Admin shall be able to manage salary, loan and allowances of employee.
8. Admin shall be able to search the specific employee.

**2. Employee**

09. Employee shall be able to login.
10. Employee shall review their information.
11. Employee shall be able to manage their personal information.
12. Employee shall be able to see their salary.
13. Employee shall be able to see their attendance.
14. Employee shall be able to request for a leave.

**3. Use Cases**

|**Use Case Title: Login**|
| - |
|**Use Case Id:** 1|
|**Requirement Id:** 1|
|**Description:** This use case describes how users gain access to the employee management system through the login process.|
|**Pre-Conditions:** Load the “Login” screen.|
|**Normal Flow**<p>1. User browse to “Login” page.</p><p>2. User enter the username and password in the returning user section.</p><p>3. System validates the username and password (successfully).</p><p>4. System provides the all the required information based on the user class.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; username and password not valid. </p><p>- System determines that the username and password is incorrect and ask the user to try again.</p>|
|<p>**Post Conditions:** </p><p>- User is either logged in or failed to login and is appropriately informed.</p>|
|**Open issues:** If the user is not registered. One will have wait for one day to process complaint to the administrator.|
|** :** Admin, employee|




|**Use Case Title: Manage Employee**|
| - |
|**Use Case Id:** 2|
|**Requirement Id:** 2|
|**Description:** This use case describes how admin manage the records of employee using the system.|
|**Pre-Conditions:**<p>1. User should be logged in as admin.</p><p>2. Admin must be in “Manage Employee” page.</p><p>3. Database should be available in online mode.</p><p>4. No duplicates of employee in the database.</p><p>5. An appropriate non-empty database should be present and also be ready for adding the new records.</p><p>6. All must-required information should be present.</p>|
|**Normal Flow**<p>1. User gets to the “Manage Employee” page.</p><p>2. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.</p><p>3. **Add**: user provides the all the information required and opts to complete the operation.</p><p>4. **Add**: system after confirmation adds the new record.</p><p>5. **Delete**: user searches the required data in the table and delete it.</p><p>6. **Delete**: System after confirmation deletes the data.</p><p>7.**Edit**: user searches the required data in the table and modify it.</p><p>8. **Edit**: user edits the form fields and opts to complete the operation.</p><p>9. **Edit**: System after confirmation update the records.</p>|
|**Alternative Flow**<p>3a. There is a problem in the data provided; some data needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:**<p>- A  new  record  added,  edited  or  deleted  in  database  and  system  and  user  is appropriately informed.</p>|
|**Open issues:**<p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|





|**Use Case Title: Manage Working History of Employee**|
| - |
|**Use Case Id:** 3|
|**Requirement Id:** 3|
|**Description:** This use case describes how admin manage the working history of employee using the system.|
|**Pre-Conditions:**</p><p>1. User should be logged in as admin.</p><p>2. Admin must be in “Manage Working History” page.</p><p>3. Database should be available in online mode.</p><p>4. Employee record must be present in database to add his/her working history.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow**</p><p>1. User gets to the “Manage Working History” page.</p><p>2. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.</p><p>3. **Add**: user provides the all the information required and opts to complete the operation.</p><p>4. **Add**: system after confirmation adds the working history of employee.</p><p>5. **Delete**: user searches the required employee working history in the table and delete it.</p><p>6. **Delete**: system after confirmation deletes the data.</p><p>7. **Edit**: user searches the required data in the table and modify it.</p><p>8. **Edit**: user edits the form fields and opts to complete the operation.</p><p>9. **Edit**: System after confirmation update the working history of respected employee.</p>|
|**Alternative Flow**<p>3a. There is a problem in the data provided; some data needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:**<p>- Working history of already existing employees must be added, edited or deleted in database and system and user is appropriately informed.</p>|
|**Open issues:**<p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|





|**Use Case Title: Manage Promotion of Employee**|
| - |
|**Use Case Id:** 4|
|**Requirement Id:** 4|
|**Description:**<p>This use case describes how admin manages the promotion of employee using the system.</p>|
|**Pre-Conditions:**<p>1. Admin must be logged in before marking employee attendance.</p><p>2. Admin must be in “Manage Promotions” page.</p><p>3. Database must be available in online mode.</p><p>4. Employee record must be present in database to promote him/her.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow**<p>1. User gets to the “Manage Promotion” page.</p><p>2. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.</p><p>3. User select the employee from the table and promote him/her.</p><p>4. System validate the changes and update the table and database.</p>|
|**Alternative Flow**<p>3a. There is a problem in the data provided; employee didn’t exist in the database. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:**<p>- Promotion of already existing employees occurs or failed and user is appropriately informed.</p>|
|**Open issues:**<p>1. What if the system displays an error message?</p><p>2. What if user employee is not present?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|





|**Use Case Title: Manage Attendance of Employee**|
| - |
|**Use Case Id:** 5|
|**Requirement Id:** 5|
|**Description:**<p>This use case describes how admin manages the attendance of employee using the system.</p>|
|**Pre-Conditions:**<p>1. Admin must be logged in before marking employee attendance.</p><p>2. Admin must be in “Manage Attendance” page.</p><p>3. Employee records must be displayed on screen to mark attendance.</p><p>4. Database must be available in online mode.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow**<p>1. user go to “Manage Attendance” Page.</p><p>2. User fill the date and category field to mark the attendance.</p><p>3. User mark the attendance as present or leave from the table of employees.</p><p>4. System after confirmation add the attendance of the employee.</p>|
|**Alternative Flow**<p>2a. There is a problem in the data provided; some data needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:**<p>- Attendance  of  employee  marked  as  present/absent  or  failed  and  user  is appropriately informed.</p>|
|**Open issues:**<p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|


|**Use Case Title: Manage Leaves of Employee**|
| - |
|**Use Case Id:** 6|
|**Requirement Id:** 6|
|**Description:** <p>This use case describes how admin manages the leaves of employee using the system.</p>|
|**Pre-Conditions:** <p>1. Admin must be logged in before accepting the leave of employee.</p><p>2. Admin must be in “Manage leaves” page.</p><p>3. Database must be available in online mode.</p><p>4. Employee record must be present in database to accept the leaves.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “Manage Leaves” page.</p><p>2. System opts for a form to be filled.</p><p>3. User fill the form and accept the request of leave.</p><p>4. System validate the changes and update the table and database.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; some field needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:** <p>- User accepts the leaves of employee or failed and user is appropriately informed.</p>|
|<p>**Open issues:** </p><p>1. What if the system displays an error message?</p><p>2. What if user employee is not present?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|


|**Use Case Title: Manage Salary of Employee**|
| - |
|**Use Case Id:** 7|
|**Requirement Id:** 7|
|**Description:** <p>This use case describes how admin manages the salary loans and allowances of employee using the system.</p>|
|**Pre-Conditions:** <p>1. User should be logged in as admin.</p><p>2. Admin must be in “Manage Salary” page.</p><p>3. Database should be available in online mode.</p><p>4. Employee record must be present in database to the manage the salary.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “Manage Salary” page.</p><p>2. System opts for a form to be filled and display a table that contain list of employees already added in the system and database.</p><p>3. **Add**: user provides the all the information required and opts to complete the operation.</p><p>4. **Add**: system after confirmation adds the salary of employee.</p><p>5. **Delete**: user searches the required employee salary in the table and delete it.</p><p>6. **Delete**: system after confirmation deletes the data.</p><p>7. **Edit**: user searches the required data in the table and modify it.</p><p>8. **Edit**: user edits the form fields and opts to complete the operation.</p><p>9. **Edit**: System after confirmation update the salary of respected employee.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; some data needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:** <p>- Salary  of  already  existing/new  employees  must  be  added,  edited  or  deleted  in database and system and user is appropriately informed.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|


|**Use Case Title: Search the Employee**|
| - |
|**Use Case Id:** 8|
|**Requirement Id:** 8|
|**Description:**  <p>This  use  case  describes  how  admin  search  the  specific  employee  using  the system.</p>|
|**Pre-Conditions:** <p>1. Admin must be logged in before marking employee attendance.</p><p>2. Admin must be in “Search Employee” page.</p><p>3. Database must be available in online mode.</p><p>4. Employee record must be present in database.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “Search Employee” page.</p><p>2. System  opts  for  Employee  Id  of  employees  that  already  added  in  the  system  and database.</p><p>3. User can search the specific employee from the table.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; employee didn’t exist in the database.</p><p>- User must add employee first and then search the employee.</p>|
|**Post Conditions:** <p>- Search the specific employee and see its information.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user employee is not present?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Admin|


|**Use Case Title: Login**|
| - |
|**Use Case Id:** 9|
|**Requirement Id:** 9|
|**Description:** <p>This use case describes how users gain access to the employee management system through the login process.</p>|
|**Pre-Conditions:** <p>Load the “Login” screen.</p>|
|**Normal Flow** <p>1. User browse to “Login” page.</p><p>2. User enter the username and password in the returning user section.</p><p>3. System validates the username and password (successfully).</p><p>4. System provides the all the required information based on the user class.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; username and password not valid. </p><p>- System determines that the username and password is incorrect and ask the user to try again.</p>|
|**Post Conditions:** <p>- User is either logged in or failed to login and is appropriately informed.</p>|
|**Open issues:** <p>If the user is not registered. One will have wait for one day to process complaint to the administrator.</p>|
|**Authority:** Admin, employee|


|**Use Case Title: Review the Information**|
| - |
|**Use Case Id:** 10|
|**Requirement Id:** 10|
|**Description:** <p>This use case describes employee review their records using the system.</p>|
|**Pre-Conditions:** <p>1. User should be logged in as employee.</p><p>2. Employee must be in “Review Records” page.</p><p>3. Database should be available in online mode.</p><p>4. No duplicates of employee in the database.</p><p>5. All information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “Review Records” page.</p><p>2. User can review their records that already added in the system and database.</p>|
|**Alternative Flow** <p>2a. There is a problem in the data provided; employee didn’t exist in the database.</p><p>- User must be added before and then he/she can review their information.</p>|
|**Post Conditions:** <p>- User can review their information.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Employee|


|**Use Case Title: Manage Information**|
| - |
|**Use Case Id:** 11|
|**Requirement Id:** 11|
|**Description:** <p>This use case describes how employee manage their record using the system.</p>|
|**Pre-Conditions:** <p>1. User should be logged in as employee.</p><p>2. Employee must be in “Manage Information” page.</p><p>3. Database should be available in the online mode.</p><p>4. No duplicates of employee in the database.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow** </p><p>1. User gets to the “Manage Information” page.</p><p>2. System opts for a form to be filled and display a table that contain list of employee information already added in the system and database.</p><p>3. **Add**: user provides the all the information required and opts to complete the operation.</p><p>4. **Add**: system after confirmation adds the new record.</p><p>5. **Delete**: user searches the required data in the table and delete it.</p><p>6. **Delete**: System after confirmation deletes the data.</p><p>7. **Edit**: user searches the required data in the table and modify it.</p><p>8. **Edit**: user edits the form fields and opts to complete the operation.</p><p>9. **Edit**: System after confirmation update the records.</p>|
|**Alternative Flow** <p>3a. There is a problem in the data provided; some data needs to be correct. </p><p>- User checks the fields and corrects the errors. User continues from the same form.</p>|
|**Post Conditions:** <p>- A  new  record  added,  edited  or  deleted  in  database  and  system  and  user  is appropriately informed.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Employee|


|**Use Case Title: View Salary**|
| - |
|**Use Case Id:** 12|
|**Requirement Id:** 12|
|**Description:** <p>This use case describes how employee can view their salary using the system.</p>|
|**Pre-Conditions:** <p>1. User should be logged in as employee.</p><p>2. Employee must be in “View Salary” page.</p><p>3. Database should be available in online mode.</p><p>4. Employee record must be present in database to view the salary.</p><p>5. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “View Salary” page.</p><p>2. User can view their salary.</p>|
|**Alternative Flow** <p>2a. There is a problem; employee didn’t exist in the database.</p>|
|**Post Conditions:** <p>- Employee can view their salary.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Employee|


|**Use Case Title: View Attendance**|
| - |
|**Use Case Id:** 13|
|**Requirement Id:** 13|
|**Description:** <p>This use case describes how employee can see the attendance using the system.</p>|
|**Pre-Conditions:** <p>1. Employee must be in “View Attendance” page.</p><p>2. Database must be available in online mode.</p><p>3. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User go to “View Attendance” Page.</p><p>2. User can see the attendance as present or leave.</p>|
|**Alternative Flow** <p>2a. There is a problem; employee didn’t exist in the database.</p>|
|**Post Conditions:** <p>- Employee can view their attendance as he/she present or leave.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user record is not available?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Employee|


|**Use Case Title: Can request for leaves**|
| - |
|**Use Case Id:** 14|
|**Requirement Id:** 14|
|**Description:** <p>This use case describes employee request for leaves using the system.</p>|
|**Pre-Conditions:** <p>1. Employee must be in “Request for leaves” page.</p><p>2. Database must be available in online mode.</p><p>3. Employee record must be present in database for requesting.</p><p>4. All must-required information should be present.</p>|
|**Normal Flow** <p>1. User gets to the “Request for leaves” page.</p><p>2. System opts for a form to be filled.</p><p>3. User fill the form and request for leave.</p><p>4. System validate the changes and update the table and database.</p>|
|**Alternative Flow** <p>2a. There is a problem; employee didn’t exist in the database.</p>|
|**Post Conditions:** <p>- Admin accepts the leaves of employee or not.</p>|
|**Open issues:** <p>1. What if the system displays an error message?</p><p>2. What if user employee is not present?</p><p>3. What if there is no connection with database?</p><p>4. What if the database crashes?</p>|
|**Authority:** Employee|


##4. Non-Functional Requirements
- Performance
  - Huge Data
    - System will deal with huge data and doesn’t crash for safety.
  - Reliability and Efficiency
    - it gives the same repeated result under the same conditions.
  - Maintenance
- Usability
  - User Friendly Interface
    - System is easy to use and does not need any further training.
  - Managing Accounts

\- System has susuu to login. When user is logged into the system then it provides the functionalities related to it.

## Methodology

## Adopted Methodology

The adopted uuhii for this project is SCRUM. SCRUM is agile methodology. Scrum principle are consistent with Agile Manifesto and use to guide development activities within the process that incorporates with framework activities. Within each framework activity, work task occurs within the process patterns call sprints. SCRUM emphasize the use of set of the software process patterns and define a set of development actions like BACKLOG, SPRINT, SCRUM MEETING, DEMOS.

## Diagram of Methodology

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.008.png?raw=true)

## Reason of Choosing Methodology
- It is flexible andff** adaptable nature throughout the** entire process.
- The Daily Scrum is a short meeting that ensure the teams are in the habit of communicating, solving problems, and creating ideas together.
- It focuses on team work.
- Throughout the SPRINTS, therghjuwuwywyhe is always visibility on the team’s tasks and the progress of each task. In addition, everyone uses the same terminology and understands their role and responsibilities.

## Project Work Plan

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.009.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.010.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.011.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.012.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.013.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.014.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.015.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.016.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.017.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.018.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.019.png?raw=true)

![](https://github.com/Arehmanali/SE-PID-09/blob/main/Screenshots/SRS%20Complete.020.png?raw=true)
