# Student Grade Management System - Design Outline

## Application Flowchart

```mermaid
graph TD
    A[Start Application] --> B[Display Main Menu]
    B --> C{User Choice}
    C -->|1| D[Add New Student]
    C -->|2| E[Add Grade to Student]
    C -->|3| F[Calculate Average Grade]
    C -->|4| G[Display All Students]
    C -->|5| H[Exit Application]
    D --> I[Get Student Details]
    I --> J[Validate Input]
    J -->|Valid| K[Add Student to System]
    J -->|Invalid| L[Show Error Message]
    K --> B
    L --> B
    E --> M[Select Student]
    M --> N[Enter Subject and Grade]
    N --> O[Validate Grade]
    O -->|Valid| P[Add Grade to Student]
    O -->|Invalid| Q[Show Error Message]
    P --> B
    Q --> B
    F --> R[Select Student]
    R --> S[Calculate Average]
    S --> T[Display Average]
    T --> B
    G --> U[Display Student Records]
    U --> B
    H --> V[End Application]
```

## Code Components

### Classes and Data Structures
1. **Student Class**
   - Properties: StudentID, Name, Dictionary<string, double> for Subjects and Grades
   - Methods: AddGrade, CalculateAverage, ToString

2. **GradeManager Class**
   - Properties: List<Student> Students
   - Methods: AddStudent, FindStudent, DisplayAllStudents

### Variables
- students: List<Student> - Stores all student records
- choice: int - Stores user menu selection
- studentId: string - Unique identifier for students
- studentName: string - Student's name
- subject: string - Subject name
- grade: double - Grade value

### Control Structures
- **Switch Statement**: For handling menu choices
- **If-Else Statements**: For input validation and error handling

### Loops
- **While Loop**: For main application loop to keep menu running
- **For Loop**: For displaying lists of students

### Methods
1. **Main()**: Entry point, runs the main application loop
2. **DisplayMenu()**: Shows options to the user
3. **AddStudent()**: Handles adding new students
4. **AddGrade()**: Handles adding grades to existing students
5. **CalculateAverage()**: Calculates and displays average grade for a student
6. **DisplayAllStudents()**: Shows all students and their grades
7. **FindStudent()**: Helper method to find a student by ID
8. **GetValidGrade()**: Helper method to validate grade input

## Task Breakdown
1. Create Student class with properties and methods
2. Create GradeManager class to manage student collection
3. Implement main application loop with menu
4. Implement user input handling
5. Implement validation for inputs
6. Test all functionality