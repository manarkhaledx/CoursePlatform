using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Course
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }
        public List<int> StudentsID { get; }

        // Constructor
        public Course(int id, string name, string description, string teacher)
        {
            ID = id;
            Name = name;
            Description = description;
            Teacher = teacher;
            StudentsID = new List<int>();
        }

        // function to add a student to the course
        public void AddStudent(int StudentID)
        {
            StudentsID.Add(StudentID);
        }

        // function to remove a student from the course
        public void RemoveStudent(int StudentID)
        {
            StudentsID.Remove(StudentID);
        }
    }
}
