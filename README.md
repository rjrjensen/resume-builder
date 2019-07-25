# Resume Builder


## Revision History

| DATE | REVISION |
| --- | --- |
| May 6, 2019 | Initial draft. Includes project summary, development methodologies, and roles and responsibilities. |
| June 17, 2019 | Finished first draft. Added more detailed introduction, description, requirements, and a list of software features. |
| July 9, 2019 | Added test plan |
| July 22, 2019 | Added project plan with a breakdown structure, a timeline, resources identified, and a risk analysis |

## Introduction

This is the Software Requirements Specification for the &quot;Resume Builder&quot; application which is a project that will be defined in the class titled CSC424: Software Engineering that is taught by Dr. David Hyson at Trident University International.

### Purpose

The purpose of this Software Requirements Specification is to describe the requirements for the &quot;Resume Builder&quot; application. It will illustrate the purpose of the application and explain the features that will be included within. This document will include sources for the requirements, the architecture that will be used when creating the application, and the design of the application.

### Intended Audience

 This Software Requirements Specification is intended to describe the &quot;Resume Builder&quot; application to my professor, Dr. David Hyson. It will also be used as a reference when I build the application from scratch for a personal project.

### Contact Information

Name: Ryan Jensen

Email: Ryan.JJensen@my.trident.edu

### Sources

 Inspiration for the outline of this Software Requirements Specification came from Table 1 in an article called Writing Software Requirements Specifications [CITATION LeV02 \l 1033]. An example of a Software Requirements Specification from some students at Chalmers.se [CITATION Gea \l 1033] is referenced every now and then for quality.

## Description

### Product Perspective

 The &quot;Resume Builder&quot; application is a tool used by job seekers for the purpose of simplifying the resume building process. This process usually includes building a targeted resume for the position the job seeker is applying to. When building multiple targeted resumes, a job seeker will typically copy and paste or remove specific skills or personal attributes from an existing resume. This becomes tiresome and repetitive.

### Product Functions

The &quot;Resume Builder&quot; application will simplify the process by storing information about the job seeker and allowing them to checkmark the information they would like to include in the resume. The application can then generate a resume with the information and skills the user selects and provide the option to download or print the resume as a PDF.

### User Classes and Characteristics

 The typical user of this application will be someone entering or moving throughout the workforce. Initially, this application will be targeting general job seekers or software developer job seekers. This can be expanded upon if there&#39;s request for additional targets.

### Operating Environment

 The final product of the &quot;Resume Builder&quot; application will operate on a hosting web server. For testing purposes and to demonstrate the project to others, the project will be compiled into a folder with a single web page for initial access and another folder for all of the resources.

### User Environment

 The final product of the &quot;Resume Builder&quot; application will be accessed from a website. After selecting personal attributes to be placed on a resume, a user will select an option to either download or print the generated copy of a resume. This will require local storage on a personal computer and/or access to a printing device.

### Design/Implementation Constraints

 Design constraints include my current knowledge of web development technology and my resources. I am a team of one that will be working on this, so I&#39;m limited to my own technology, my own skills, and my own free time (I am a full time software developer).

### Requirements Elicitation

Requirements were gathered from four reliable sources. The first source for requirements was myself. I am currently a mid-level software developer for a company. I have an extensive work history and background and I have plenty of experience so far that I can provide excellent input into what should be required of this project.

The second source for requirements was a senior-level software engineer that I know named Tareq Rabadi that critiques my own resumes and others. He gave me plenty of input into what should go into this application and the features that would be valuable.

The third source for requirements was my close friend named Erin Woltjer that is currently in her final year as a student of a human resources program. She has educational material and knowledge of the resume process and the psychology behind a good resume. This was very valuable in creating the requirements for the &quot;Resume Builder&quot; application.

The fourth and final source for requirements was a senior-level professional recruiter named Carrie Danger from a company called Robert Half Technology that connected me with my current job. She was the one that gave final critiques to my resume. She has 19 years of experience in job seeking and resumes and has seen first-hand the evolution of the resume. Without her, this project would not be possible.

### Software Architecture

 The &quot;Resume Builder&quot; application requires a full-stack architecture to function properly. This includes a user interface, an API, and a database. The architecture will follow most the Model-View-Controller architecture.

## External Interface Requirements

### User Interfaces

The View part of the MVC architecture will be the user facing interface and it will be built with basic HTML pages initially, but will implement Twitter Bootstrap styling and Angular responsiveness. A user will enter the application from the initial URL and be presented with a login screen. They will either login or create a new account. A new account creation will be followed by a form page where the new user can enter information about their work history, skills, and personal attributes that they would like on a resume.

After a new user form is submitted or an existing user logs in with their credentials, a page showing some options will show. The options will be to either build a resume from existing data or to add more information to their profile. Choosing to add more information will bring the user to an edit page identical to the new user page, but with their existing information filled in. They will be able to add new lines to their profile and then submit the fresh data.

When choosing the option to build a resume, they&#39;ll be taken to a dynamic page where they will select a partially-filled template resume or a blank resume. They will then start check-marking the information from their profile that they&#39;d like to include on the resume. Once all of the information is selected, a Generate button can be clicked to fill in the chosen template with their information dynamically. They will be able to edit the generated resume to their choosing, then select either Print or Download, which will either present a Print dialog box to download the PDF resume or present a Download dialog to save the generated PDF resume to local storage.

### Hardware Interfaces

 Since this application is on the web, any device with a web browser installed and access to the internet should be able to access and use this application. The assumption is that most users will either use a mobile phone, a tablet, a laptop, or a desktop computer that have access to local storage and/or a printer.

### Software Interfaces

The user interface communicates with an API to perform basic CRUD operations that create data, read data, update data, or delete data. The Controller will house the endpoints in the API that will be called by events in the View (like button clicks) that will move and transform data between the user interface and the SQL database. The Model will be the same structure for the data in both the API and the SQL database.

### Communication Protocols and Interfaces

 The API will use RESTful services to facilitate communication between the front-end and the back-end.

## Software Features

### Feature A

#### Title.

Create Account

#### Description.

The user should be able to create a new account with a username/email and a password and input all of their hirable traits. This includes their name, job title, address information, a small biography or mission statement, previous jobs&#39; information, educational background, special skills, achievements, and all of their respective dates.

#### Requirements.

No previous experience with the application is required. The application requires the user interface, the API, and the SQL database to be functioning.

### Feature B

#### Title.

Login to Existing Account

#### Description.

The user should be able to login using the credentials created when setting up a new account. They should be able to view, add, and edit their information and build a new resume.

#### Requirements.

A user must have used Feature A first to be able to use Feature B.

### Feature C

#### Title.

Add/View/Edit Information

#### Description.

The user should be able to add, view, and edit their information after logging in or creating an account.

#### Requirements.

The user must have used Feature A or Feature B first to be able to use Feature C.

### Feature D

#### Title.

Generate Resume

#### Description.

The user should be able to choose existing information from their profile to import into a resume template. They should then be able to generate a resume to download or print.

#### Requirements.

The user must have used Feature A or Feature B first then used Feature C if more information is required before being able to use Feature D.

## Testing

### Quality Standards

#### Test A

A user should be able to easily and successfully create an account on the resume builder website.

#### Test B

After account creation, a user should be able to easily and successfully add their personal attributes.

#### Test C

After adding all of their attributes, a user should be able to click a button and easily move to the resume building tool to select the attributes they&#39;d like on their finished resume.

#### Test D

The user should be able to click another button to finish the resume and have it presented in a resume format.

#### Test E

The user should be able to print the finished product in an 8.5&quot; X 11&quot; standard format.

#### Test F

The user should be able to log out, log back in, and add additional attributes.


### White Box Test Plan

The login/register page should be able to pass authentication information to the backend of the project and allow the user to recall their information if they logged in previously or store their information if they&#39;re a new user. If they&#39;re new, after entering their credentials, the back end should store their information and encrypt it for security. This falls under Test A. On the page that takes personal information about how to contact them and their job and educational history, a submission should store the information from the form in a relational database. This information should easily be recalled based on the user&#39;s identification. This falls under Test B.

When the user requests to build a resume, they should be able to select from all of their attributes. First, all of the user&#39;s information should be brought up from the back end to be presented. Then, selecting from this collection should populate a list to be used when constructing the finished resume. This falls under Test C. Finishing this selection should put that list to use and construct a finished product to print or save. This falls under Test D and Test E

### Black Box Test Plan

 Upon first arrival to the website, a new user should be able to create an account and add all of their information into a well organized and responsive form. This falls under Test A, Test B. Upon reentry into the website, a user should be able to easily login and see all of the information they previously entered and saved. This falls under Test F. When the user wants to move on to selecting attributes for a resume, they should be able to click checkboxes next to rows in neatly organized tables of their personal attributes. This falls under Test C. A Finish button should bring them to a view of their finished resume. This falls under Test D and Test E.

### Test Results

There are no test results yet as this is an unfinished product.

## Project Plan

### Work Breakdown Structure

A work breakdown structure is defined as a &quot;deliverable-oriented hierarchical decomposition of the work to be executed by the project team to accomplish the project objectives and create the required deliverables&quot; [CITATION Coh18 \l 1033].

In my Work Breakdown Structure, each of the subprojects under Backend and Frontend should take about a week to create.

### Milestones

1. Database
  1. The database that holds all of this information is a deliverable by itself. This is a valuable structure that can organize and hold all of the information about a person.
2. API
  1. The API has the functionality to put information into the database and pull information out as a list.
  2. Authentication could be included in this API.
3. Frontend
  1. The entire front end in its most basic form is a deliverable. A simple login/registration page, the information entrance page, the selection page, and the generated resume page.
4. Reactive Frontend
  1. This is a major user experience update to a bland initial frontend. This includes color, animations, and overall pleasing aesthetic.

### Timeline

### Critical Path

From the timeline, it&#39;s shown that every part of this application could take between 3 and 5 days in a week each. There is no major critical path. The two most critical paths are the Frontend and the Reactive Frontend. These are the most time consuming and could hinder the timeline the most. To increase efficiency, an additional developer that&#39;s skilled in front-end languages should be hired to help complete the Frontend task and the Reactive Frontend task.

### Risk Analysis

 Some of the highest risk lies in the Authentication piece of the project. This will need to be tested thoroughly to ensure that data is safe and nothing can harm a user. The next level of risk is in how much time it will take to create the frontend of the project. This is the most time-consuming.

## References

Cohen, E. (2018, March 15). _A Beginner-Friendly Guide to Work Breakdown Structures (WBS)._ Retrieved from Workamajig: https://www.workamajig.com/blog/guide-to-work-breakdown-structures-wbs

Eriksson, U. (2016, November 28). _White Box Testing Example – Step by Step Guide on Everything you Need to Know._ Retrieved from ReQtest: https://reqtest.com/testing-blog/white-box-testing-example/

Geagea, S., Zhang, S., Sahlin, N., Hasibi, F., Hameed, F., Rafiyan, E., &amp; Ekberg, M. (n.d.). _Software Requirements Specification - Amazing Lunch Indicator._ Retrieved from Chalmers.se: http://www.cse.chalmers.se/~feldt/courses/reqeng/examples/srs\_example\_2010\_group2.pdf

Le Vie, Jr., D. (2002). _Writing Software Requirements Specifications_. Retrieved from Calpoly.edu: http://users.csc.calpoly.edu/~csturner/courses/508w10/Readings/writeReqtsTutorial.html
