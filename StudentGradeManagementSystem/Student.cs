using System;
using System.Collections.Generic;

namespace StudentGradeManagementSystem
{
    /// <summary>
    /// Represents a student with an ID, name, and collection of grades
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student
        /// </summary>
        public string StudentId { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the student
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the dictionary of subjects and their corresponding grades
        /// Key is the subject name, Value is the grade
        /// </summary>
        public Dictionary<string, double> Grades { get; set; }

        /// <summary>
        /// Initializes a new instance of the Student class with the specified ID and name
        /// </summary>
        /// <param name="studentId">The unique identifier for the student</param>
        /// <param name="name">The name of the student</param>
        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
            Grades = new Dictionary<string, double>();
        }

        /// <summary>
        /// Adds a grade for a specific subject to the student's record
        /// </summary>
        /// <param name="subject">The subject name</param>
        /// <param name="grade">The grade value (must be between 0 and 100)</param>
        /// <exception cref="ArgumentException">Thrown when grade is not between 0 and 100</exception>
        public void AddGrade(string subject, double grade)
        {
            // Validate grade is between 0 and 100
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100");
            }
            
            Grades[subject] = grade;
        }

        /// <summary>
        /// Calculates the average of all grades for the student
        /// </summary>
        /// <returns>The average grade, or 0.0 if no grades exist</returns>
        public double CalculateAverage()
        {
            if (Grades.Count == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (var grade in Grades.Values)
            {
                sum += grade;
            }
            
            return sum / Grades.Count;
        }

        /// <summary>
        /// Returns a string representation of the student
        /// </summary>
        /// <returns>Formatted string with student ID, name, and average grade</returns>
        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {Name}, Average Grade: {CalculateAverage():F2}";
        }
    }
}