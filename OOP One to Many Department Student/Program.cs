using OOP_One_to_Many_Department_Student.Departments;
using System;

public class Program
{
    public static void Main()
    {
        Department department = new Department
        {
            DeptNo = 1,
            Name = "Computer Science",
            Description = "Department of Computer Science"
        };

        string message;

        department.AddStudent(new Student { RegNo = 101, Name = "Atik Hassan" }, out message);
        Console.WriteLine(message);
        department.AddStudent(new Student { RegNo = 102, Name = "Mehedi Hassan" }, out message);
        Console.WriteLine(message);
        department.AddStudent(new Student { RegNo = 103, Name = "Ashib Hassan" }, out message);
        Console.WriteLine(message);
        department.AddStudent(new Student { RegNo = 101, Name = "Duplicate Atik" }, out message);
        Console.WriteLine(message);

        department.UpdateStudent(102, "Mehedi Hassan", out message);
        Console.WriteLine(message);
        department.UpdateStudent(999, "No Name", out message);
        Console.WriteLine(message);

        department.RemoveStudent(103, out message);
        Console.WriteLine(message);
        department.RemoveStudent(999, out message);
        Console.WriteLine(message);

        Console.WriteLine("Sl. RegNo. Name");
        int serial = 1;
        foreach (var student in department.GetAllStudents())
        {
            Console.WriteLine($"{serial}. {student.RegNo} {student.Name}");
            serial++;
        }

        Console.WriteLine($"Total Students: {department.TotalStudents()}");
    }
}
