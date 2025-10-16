using System;

namespace StudentGradeManagementSystem
{
    /// <summary>
    /// Main program class for the Student Grade Management System
    /// This console application allows users to manage student records and grades
    /// </summary>
    class Program
    {
        static GradeManager gradeManager = new GradeManager();
        
        /// <summary>
        /// Entry point of the application
        /// Initializes the grade manager and starts the main application loop
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Management System!");
            
            bool running = true;
            while (running)
            {
                DisplayMenu();
                int choice = GetMenuChoice();
                
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddGrade();
                        break;
                    case 3:
                        CalculateAverage();
                        break;
                    case 4:
                        gradeManager.DisplayAllStudents();
                        break;
                    case 5:
                        running = false;
                        Console.WriteLine("Thank you for using the Student Grade Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        
        /// <summary>
        /// Displays the main menu options to the user
        /// </summary>
        static void DisplayMenu()
        {
            Console.WriteLine("\n=== Student Grade Management System ===");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. Add Grade to Student");
            Console.WriteLine("3. Calculate Average Grade");
            Console.WriteLine("4. Display All Students");
            Console.WriteLine("5. Exit");
            Console.WriteLine("======================================");
            Console.Write("Please select an option (1-5): ");
        }
        
        /// <summary>
        /// Gets and validates the user's menu choice
        /// Ensures the input is a valid integer between 1 and 5
        /// </summary>
        /// <returns>Valid menu choice (1-5)</returns>
        static int GetMenuChoice()
        {
            string input = Console.ReadLine();
            int choice;
            
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 5)
            {
                Console.Write("Invalid input. Please enter a number between 1 and 5: ");
                input = Console.ReadLine();
            }
            
            return choice;
        }
        
        /// <summary>
        /// Handles adding a new student to the system
        /// Prompts user for student ID and name, then adds to grade manager
        /// </summary>
        static void AddStudent()
        {
            Console.WriteLine("\n--- Add New Student ---");
            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();
            
            // Validate student ID is not empty
            while (string.IsNullOrWhiteSpace(studentId))
            {
                Console.Write("Student ID cannot be empty. Please enter a valid ID: ");
                studentId = Console.ReadLine();
            }
            
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            
            // Validate student name is not empty
            while (string.IsNullOrWhiteSpace(studentName))
            {
                Console.Write("Student name cannot be empty. Please enter a valid name: ");
                studentName = Console.ReadLine();
            }
            
            try
            {
                Student newStudent = new Student(studentId, studentName);
                gradeManager.AddStudent(newStudent);
                Console.WriteLine($"Student {studentName} (ID: {studentId}) added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Handles adding a grade to an existing student
        /// Prompts user for student ID, subject, and grade value
        /// </summary>
        static void AddGrade()
        {
            if (gradeManager.Students.Count == 0)
            {
                Console.WriteLine("No students available. Please add a student first.");
                return;
            }
            
            Console.WriteLine("\n--- Add Grade to Student ---");
            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();
            
            Student student = gradeManager.FindStudent(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            
            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine();
            
            // Validate subject is not empty
            while (string.IsNullOrWhiteSpace(subject))
            {
                Console.Write("Subject cannot be empty. Please enter a valid subject: ");
                subject = Console.ReadLine();
            }
            
            Console.Write("Enter Grade (0-100): ");
            double grade = GetValidGrade();
            
            try
            {
                student.AddGrade(subject, grade);
                Console.WriteLine($"Grade {grade} for {subject} added to {student.Name} successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Gets and validates a grade value from the user
        /// Ensures the input is a valid double between 0 and 100
        /// </summary>
        /// <returns>Valid grade value (0-100)</returns>
        static double GetValidGrade()
        {
            string input = Console.ReadLine();
            double grade;
            
            while (!double.TryParse(input, out grade) || grade < 0 || grade > 100)
            {
                Console.Write("Invalid grade. Please enter a number between 0 and 100: ");
                input = Console.ReadLine();
            }
            
            return grade;
        }
        
        /// <summary>
        /// Handles calculating and displaying the average grade for a student
        /// Prompts user for student ID and displays the calculated average
        /// </summary>
        static void CalculateAverage()
        {
            if (gradeManager.Students.Count == 0)
            {
                Console.WriteLine("No students available. Please add a student first.");
                return;
            }
            
            Console.WriteLine("\n--- Calculate Average Grade ---");
            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();
            
            Student student = gradeManager.FindStudent(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            
            double average = student.CalculateAverage();
            if (average == 0)
            {
                Console.WriteLine($"{student.Name} has no grades recorded yet.");
            }
            else
            {
                Console.WriteLine($"{student.Name}'s average grade is: {average:F2}");
            }
        }
    }
}