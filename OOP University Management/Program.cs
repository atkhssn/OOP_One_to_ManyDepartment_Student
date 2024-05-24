using OOP_University_Management.University_Management;

University university = new University { Name = "My University" };

string message;

Department csDept = new Department { DeptNo = 1, Name = "Computer Science", Description = "Department of Computer Science" };
university.AddDepartment(csDept, out message);
Console.WriteLine(message);

Department eeDept = new Department { DeptNo = 2, Name = "Electrical Engineering", Description = "Department of Electrical Engineering" };
university.AddDepartment(eeDept, out message);
Console.WriteLine(message);

csDept.AddStudent(new Student { RegNo = 101, Name = "Atik Hassan" }, out message);
Console.WriteLine(message);
csDept.AddStudent(new Student { RegNo = 102, Name = "Mehedi Hassan" }, out message);
Console.WriteLine(message);

eeDept.AddStudent(new Student { RegNo = 201, Name = "Ashib Hassan" }, out message);
Console.WriteLine(message);

university.UpdateDepartment(1, "CS", "Department of CS", out message);
Console.WriteLine(message);

university.RemoveDepartment(2, out message);
Console.WriteLine(message);

Console.WriteLine("\nDepartments and their Students:");
foreach (var dept in university.GetAllDepartments())
{
    Console.WriteLine($"\nDepartment: {dept.Name} ({dept.DeptNo}) - {dept.Description}");
    Console.WriteLine("Sl. RegNo. Name");
    int serial = 1;
    foreach (var student in dept.GetAllStudents())
    {
        Console.WriteLine($"{serial}. {student.RegNo} {student.Name}");
        serial++;
    }
}

Console.WriteLine($"\nTotal Students in CS Department: {csDept.TotalStudents()}");