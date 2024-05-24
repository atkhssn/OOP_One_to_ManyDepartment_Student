using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_University_Management.University_Management
{
    public class University
    {
        public string Name { get; set; }
        private List<Department> departments = new List<Department>();

        public bool AddDepartment(Department department, out string message)
        {
            if (departments.Exists(d => d.DeptNo == department.DeptNo))
            {
                message = "A department with the same DeptNo already exists.";
                return false;
            }
            departments.Add(department);
            message = "Department added successfully.";
            return true;
        }

        public bool RemoveDepartment(int deptNo, out string message)
        {
            Department department = departments.Find(d => d.DeptNo == deptNo);
            if (department != null)
            {
                departments.Remove(department);
                message = "Department removed successfully.";
                return true;
            }
            message = "Department not found.";
            return false;
        }

        public bool UpdateDepartment(int deptNo, string newName, string newDescription, out string message)
        {
            Department department = departments.Find(d => d.DeptNo == deptNo);
            if (department != null)
            {
                department.Name = newName;
                department.Description = newDescription;
                message = "Department updated successfully.";
                return true;
            }
            message = "Department not found.";
            return false;
        }

        public Department GetDepartmentByDeptNo(int deptNo)
        {
            return departments.Find(d => d.DeptNo == deptNo);
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
