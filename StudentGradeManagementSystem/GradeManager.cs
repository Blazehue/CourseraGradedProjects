using System;
using System.Collections.Generic;

namespace StudentGradeManagementSystem
{
    /// <summary>
    /// Manages a collection of students and provides operations on the collection
    /// </summary>
    public class GradeManager
    {
        /// <summary>
        /// Gets or sets the list of students managed by this GradeManager
        /// </summary>
        public List<Student> Students { get; set; }

        /// <summary>
        /// Initializes a new instance of the GradeManager class
        /// </summary>
        public GradeManager()
        {
            Students = new List<Student>();
        }

        /// <summary>
        /// Adds a student to the collection
        /// </summary>
        /// <param name="student">The student to add</param>
        /// <exception cref="ArgumentException">Thrown when a student with the same ID already exists</exception>
        public void AddStudent(Student student)
        {
            // Check if student with same ID already exists
            foreach (Student existingStudent in Students)
            {
                if (existingStudent.StudentId == student.StudentId)
                {
                    throw new ArgumentException("A student with this ID already exists.");
                }
            }
            
            Students.Add(student);
        }

        /// <summary>
        /// Finds a student by their ID
        /// </summary>
        /// <param name="studentId">The ID of the student to find</param>
        /// <returns>The student with the specified ID, or null if not found</returns>
        public Student FindStudent(string studentId)
        {
            foreach (Student student in Students)
            {
                if (student.StudentId == studentId)
                {
                    return student;
                }
            }
            
            return null;
        }

        /// <summary>
        /// Displays all students in the collection with their grades
        /// </summary>
        public void DisplayAllStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- Student Records ---");
            for (int i = 0; i < Students.Count; i++)
            {
                Student student = Students[i];
                Console.WriteLine($"{i + 1}. {student}");
                
                if (student.Grades.Count > 0)
                {
                    Console.WriteLine("   Grades:");
                    foreach (var grade in student.Grades)
                    {
                        Console.WriteLine($"     {grade.Key}: {grade.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("   No grades recorded.");
                }
                
                Console.WriteLine();
            }
        }
    }
}