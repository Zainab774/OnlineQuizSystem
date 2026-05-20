Online Quiz System – Deployment Guide

Requirements
- Windows OS
- Visual Studio Community 2022
- .NET 10.0
- Newtonsoft.Json (installed via NuGet automatically)

How to Run
1. Open OnlineQuizSystemProject.slnx in Visual Studio
2. Restore NuGet packages if prompted
3. Build the solution (Ctrl+Shift+B)
4. Press F5 to run the project

Default Credentials

Admin/Teacher
Username: admin
Password: admin123

Student
Username: student1
Password: pass123
(students 1-100 are available, all use pass123)

Data Storage
- The system uses a JSON file (data.json) for data persistence
- data.json is auto-created on first run in the same folder as the executable
- No database installation is required
- To reset all data: delete data.json and restart the application