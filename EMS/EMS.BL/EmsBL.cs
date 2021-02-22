using EMS.DAL;
using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BL
{
    public class EmsBL
    {
        public static bool AddDepartment(Department dept)
        {
            bool isAdded = EmsDAL.AddDepartment(dept);
            return isAdded;
        }

        public static bool AddEmployee(Employee emp)
        {
            bool isAdded = EmsDAL.AddEmployee(emp);
            return isAdded;
        }

        public static IEnumerable<Employee> GetEmployeeList()
        {
            IEnumerable<Employee> employees = EmsDAL.GetEmployeeList();
            return employees;
        }

        public static bool UpdateEmployee(Employee employee)
        {
            bool isUpdated = EmsDAL.UpdateEmployee(employee);
            return isUpdated;
        }

        public static Employee GetEmployeeById(int employeeId)
        {
            Employee employee = EmsDAL.GetEmployeeById(employeeId);
            return employee;
        }

        public static bool DeleteEmployee(Employee employee)
        {
            bool isDeleted = EmsDAL.DeleteEmployee(employee);
            return isDeleted;
        }

        public static Department GetDepartmentById(int departmentId)
        {
            Department department = EmsDAL.GetDepartmentbyId(departmentId);
            return department;
        }

        public static bool UpdateDepartment(Department department)
        {
            bool isUpdated = EmsDAL.UpdateDepartment(department);
            return isUpdated;
        }

        public static bool DeleteDepartment(Department department)
        {
            bool isDeleted = EmsDAL.DeleteDepartment(department);
            return isDeleted;
        }

        public static IEnumerable<Department> GetDepartmentList()
        {
            IEnumerable<Department> departments = EmsDAL.GetDepartmentList();
            return departments;
        }

        public static bool EmployeeDetails(Employee employee)
        {
            bool isFound = EmsDAL.EmployeeDetails(employee);
            return isFound;
        }
    }
}
