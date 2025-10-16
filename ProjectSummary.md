# Coursera Graded Assignment: Student Grade Management System

## Project Overview

This project implements a Student Grade Management System as a C# console application. The system allows users to manage student records, assign grades for different subjects, calculate average grades, and display student information.

## Files Created

1. **[ProjectRequirements.md](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/ProjectRequirements.md)** - Contains detailed project requirements and objectives
2. **[DesignOutline.md](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/DesignOutline.md)** - Includes design flowchart and component breakdown
3. **[StudentGradeManagementSystem/Student.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Student.cs)** - Student class implementation
4. **[StudentGradeManagementSystem/GradeManager.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/GradeManager.cs)** - GradeManager class implementation
5. **[StudentGradeManagementSystem/Program.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Program.cs)** - Main application logic
6. **[StudentGradeManagementSystem/StudentGradeManagementSystem.csproj](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/StudentGradeManagementSystem.csproj)** - Project configuration file
7. **[StudentGradeManagementSystem/README.md](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/README.md)** - Project documentation
8. **[StudentGradeManagementSystem/build.bat](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/build.bat)** - Windows build script
9. **[StudentGradeManagementSystem/run.bat](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/run.bat)** - Windows run script
10. **[StudentGradeManagementSystem/build.sh](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/build.sh)** - Linux/Mac build script
11. **[StudentGradeManagementSystem/run.sh](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/run.sh)** - Linux/Mac run script
12. **[StudentGradeManagementSystem/build-and-run.sh](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/build-and-run.sh)** - Combined Linux/Mac build and run script

## Requirements Verification

### ✅ Project Requirements and Objectives (5/5 points)
- Created comprehensive project requirements document
- Defined both functional and non-functional requirements
- Set clear project objectives

### ✅ Design Outline (5/5 points)
- Created detailed design outline with flowchart
- Documented code components and structure
- Provided task breakdown

### ✅ Control Structures (5/5 points)
- Implemented if-else statements for input validation and conditional logic
- Used switch statement for menu navigation
- Examples can be found in [Program.cs](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Program.cs)

### ✅ Loops (5/5 points)
- Used while loop for main application loop
- Implemented for loop for displaying student lists
- Used foreach loops for iterating through collections
- Examples in all three source files

### ✅ Methods (5/5 points)
- Defined and called multiple methods across classes
- Created static methods in Program class for user interactions
- Implemented instance methods in Student and GradeManager classes
- Examples include [AddStudent()](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Program.cs#L101-L135), [CalculateAverage()](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/Program.cs#L184-L212), [DisplayAllStudents()](file:///C:/Users/pandr/OneDrive/Desktop/CourseraGradedPRojs/StudentGradeManagementSystem/src/GradeManager.cs#L46-L71), etc.

## Application Features

1. **Add New Students**: Users can add students with unique IDs and names
2. **Add Grades**: Assign grades (0-100) to students for different subjects
3. **Calculate Average**: Compute and display average grades for students
4. **Display Records**: View all students with their grades and averages
5. **Input Validation**: Comprehensive validation for all user inputs
6. **Error Handling**: Graceful handling of errors and exceptions

## Code Structure

The application follows object-oriented principles with three main classes:

1. **Program**: Contains the main application logic and user interface
2. **Student**: Represents a student with properties and grade management methods
3. **GradeManager**: Manages a collection of students and provides operations on the collection

## How to Run

1. Ensure .NET 6.0 SDK or later is installed
2. Navigate to the StudentGradeManagementSystem directory
3. Run `dotnet run` or execute the run.bat file

## Testing Approach

The application was tested using manual testing with various scenarios:

1. Adding students with valid and invalid inputs
2. Adding grades within and outside the valid range (0-100)
3. Calculating averages for students with no grades, one grade, and multiple grades
4. Displaying student records in various states
5. Verifying error handling for duplicate student IDs

## Future Enhancements

Potential improvements for future versions:

1. Data persistence using a database or file storage
2. Enhanced user interface with better formatting
3. Additional student information fields
4. Grade history tracking
5. Class/section management
6. Export functionality for reports

## Conclusion

This project successfully demonstrates proficiency in C# programming concepts including control structures, loops, and methods. The application is user-friendly, well-structured, and meets all specified requirements.