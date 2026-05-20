Online Quiz System – Deployment Guide

Requirements
Windows OS
Visual Studio Community 2022
.NET Framework 4.8
Newtonsoft.Json package

How to Run
Open the .sln file in Visual Studio.
Restore NuGet packages if prompted.
Build the solution.
Press F5 to run the project.

Required Packages
Newtonsoft.Json

Default Credentials

Teacher
Username: teacher
Password: teacher123

Student
Username: student
Password: student123

Data Storage
The system uses a JSON file (data.json) for data persistence.
All quizzes, users, and results are stored inside the JSON file.