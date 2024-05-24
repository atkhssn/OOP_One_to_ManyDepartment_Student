using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_University_Management.University_Management
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private List<Student> students = new List<Student>();

        public bool AddStudent(Student student, out string message)
        {
            if (students.Exists(s => s.RegNo == student.RegNo))
            {
                message = "A student with the same RegNo already exists.";
                return false;
            }
            students.Add(student);
            message = "Student added successfully.";
            return true;
        }

        public bool UpdateStudent(int regNo, string newName, out string message)
        {
            Student student = students.Find(s => s.RegNo == regNo);
            if (student != null)
            {
                student.Name = newName;
                message = "Student updated successfully.";
                return true;
            }
            message = "Student not found.";
            return false;
        }

        public bool RemoveStudent(int regNo, out string message)
        {
            Student student = students.Find(s => s.RegNo == regNo);
            if (student != null)
            {
                students.Remove(student);
                message = "Student removed successfully.";
                return true;
            }
            message = "Student not found.";
            return false;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public int TotalStudents()
        {
            return students.Count;
        }
    }
}
