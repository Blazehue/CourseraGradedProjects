# Student Grade Management System

This is a C# console application that allows users to manage student records and grades.

## Features

1. Add new students with ID and name
2. Add grades for different subjects to students
3. Calculate average grades for students
4. Display all student records with their grades

## Project Structure

- [Program.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Program.cs) - Main application entry point and user interface
- [Student.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Student.cs) - Student class with properties and methods
- [GradeManager.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/GradeManager.cs) - Class to manage collection of students

## Requirements Implemented

✅ Project requirements and objectives documented
✅ Design outline with flowchart created
✅ Control structures (if-else and switch statements)
✅ Loops (for and while)
✅ Methods that are defined and called

## How to Run

### Windows:
1. Install .NET 6.0 SDK or later
2. Navigate to the project directory
3. Run the command: `dotnet run`
4. Alternatively, run `run.bat` or `build.bat`

### Linux/Mac:
1. Install .NET 6.0 SDK or later
2. Navigate to the project directory
3. Make scripts executable: `chmod +x *.sh`
4. Run `./run.sh` or `./build.sh`

## Application Usage

1. **Add New Student**: Enter student ID and name
2. **Add Grade to Student**: Select student by ID, enter subject and grade (0-100)
3. **Calculate Average Grade**: Select student by ID to see their average grade
4. **Display All Students**: View all students and their grades
5. **Exit**: Close the application

## Testing the Application

To test the application functionality:

1. Run the application using any of the methods described above
2. Add a new student with ID and name
3. Add several grades for different subjects to the student
4. Calculate and verify the average grade
5. Add additional students and test all functionality

Example test scenario:
- Add student with ID "S001" and name "John Doe"
- Add grade of 85 for "Mathematics"
- Add grade of 92 for "Science"
- Calculate average (should be 88.50)

## Scripts Included

- `run.bat` - Windows batch file to run the application
- `build.bat` - Windows batch file to build the application
- `run.sh` - Bash script to run the application (Linux/Mac)
- `build.sh` - Bash script to build the application (Linux/Mac)
- `build-and-run.sh` - Combined bash script to build and run the application (Linux/Mac)

## Code Elements

### Control Structures
- Switch statement for menu navigation
- If-else statements for input validation and conditional logic

### Loops
- While loop for main application loop
- For loop for displaying numbered student lists
- Foreach loops for iterating through collections

### Methods
- Multiple methods in each class for specific functionality
- Static methods in Program class for user interactions
- Instance methods in Student and GradeManager classes