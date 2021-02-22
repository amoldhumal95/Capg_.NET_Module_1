using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMS.DAL
{
    public class EmsDAL
    {
        static List<Department> departments = new List<Department>();
        static int deptCounter = 1;
        public static bool AddDepartment(Department dept)
        {
            dept.Id = deptCounter++;
            departments.Add(dept);
            return true;
        }


        static List<Employee> employees = new List<Employee>();
        static int empCounter = 1;
        public static bool AddEmployee(Employee emp)
        {
            emp.Id = empCounter++;
            employees.Add(emp);
            return true;
        }

        public static IEnumerable<Employee> GetEmployeeList()
        {
            return employees;
        }

        public static bool UpdateEmployee(Employee employee)
        {
            Employee existingEmp = employees.Find(e => e.Id == employee.Id);
            existingEmp.Name = employee.Name;
            existingEmp.DateOfJoining = employee.DateOfJoining;
            existingEmp.Salary = employee.Salary;
            existingEmp.Mail = employee.Mail;
            existingEmp.Gender = employee.Gender;
            existingEmp.Hobbies = employee.Hobbies;
            existingEmp.DepartmentId = employee.DepartmentId;

            return true;
        }

        public static bool UpdateDepartment(Department department)
        {
            Department existingDept = departments.Find(d => d.Id == department.Id);
            existingDept.Name = department.Name;
            //existingDept.Id = department.Id;
            return true;
        }

        public static bool DeleteDepartment(Department department)
        {
            Department deleteDept = departments.Find(e => e.Id == department.Id);
            departments.Remove(deleteDept);
            return true;
        }

        public static IEnumerable<Department> GetDepartmentList()
        {
            return departments;
        }

        public static Department GetDepartmentbyId(int departmentId)
        {
            Department department = departments.Find(d => d.Id == departmentId);
            return department;
        }

        public static bool EmployeeDetails(Employee employee)
        {
            Employee empDetails = employees.Find(e => e.Id == employee.Id);
            employees.Contains(empDetails);
            return true;
        }

        public static bool DeleteEmployee(Employee employee)
        {
            Employee deleteEmp = employees.Find(e => e.Id == employee.Id);
            employees.Remove(deleteEmp);
            return true;
        }

        public static Employee GetEmployeeById(int employeeId)
        {
            Employee employee = employees.Find(e => e.Id == employeeId);
            return employee;
        }
    }
}
