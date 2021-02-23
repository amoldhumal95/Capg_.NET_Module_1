using EMS.BL;
using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string input;
                int choice;
                do
                {
                    Console.WriteLine("*****************************************************\n"+
                       "1.Add Department\n" +
                       "2.Update Department\n" +
                       "3.Delete Department\n" +
                       "4.List Dipartments\n" +
                       "5.Add Employee\n" +
                       "6.Update Employee\n" +
                       "7.Delete Employee\n" +
                       "8.List Employees\n" +
                       "9.Show Employee detail.\n"+
                       "10.Exit\n"+
                       "*****************************************************\n");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out choice));

                switch (choice)
                {
                    case 1:
                        AddDepartment();
                        break;
                    case 2:
                        UpdateDepartment();
                        break;
                    case 3:
                        DeleteDepartment();
                        break;
                    case 4:
                        ListDepartment();
                        break;

                    case 5:
                        AddEmployee();
                        break;
                    case 6:
                        UpdateEmployee();
                        break;
                    case 7:
                        DeleteEmployee();
                        break;
                    case 8:
                        ListEmployees();
                        break;
                    case 9:
                        ShowEmployeeDetails();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                    
                    
                    

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (true);

           // Console.ReadLine();


        }

        private static void ShowEmployeeDetails()
        {
            int employeeId;
            do
            {
                Console.WriteLine("Enter employee id for getting details:");
            } while (!int.TryParse(Console.ReadLine(),out employeeId));
            Employee employee = EmsBL.GetEmployeeById(employeeId);
            if (employee == null)
            {
                Console.WriteLine("Employee does not exists");
            }
            else
            {
                bool isFound = EmsBL.EmployeeDetails(employee);
                if (isFound)
                {
                    Console.WriteLine("Employee found successfully");
                    Console.WriteLine(employee);
                }
            }
        }

        private static void ListDepartment()
        {
            IEnumerable<Department> departments = EmsBL.GetDepartmentList();
            foreach (var department in departments)
            {
                Console.WriteLine(department);
            }
        }

        private static void DeleteDepartment()
        {
            int departmentId;
            do
            {
                Console.WriteLine("Enter the department ID");
            } while (!int.TryParse(Console.ReadLine(), out departmentId));

            Department department = EmsBL.GetDepartmentById(departmentId);

            if (department == null)
            {
                Console.WriteLine("Department does not exist");
            }
            else
            {
                bool isDeleted = EmsBL.DeleteDepartment(department);
                if (isDeleted)
                {
                    Console.WriteLine("Department deleted");
                }
                else
                {
                    Console.WriteLine("Delete failed");
                }
            }
        }

        private static void UpdateDepartment()
        {
            int departmentId;
            do
            {
                Console.WriteLine("Enter the department ID");
            } while (!int.TryParse(Console.ReadLine(), out departmentId));

            Department department = EmsBL.GetDepartmentById(departmentId);

            if (department == null)
            {
                Console.WriteLine("Department does not exist");
            }
            else
            {
                string departmentName;
                do
                {
                    Console.WriteLine("Enter Department Name: ");
                    departmentName = Console.ReadLine();


                } while (string.IsNullOrEmpty(departmentName));
                department.Name = departmentName;

                bool isUpdated = EmsBL.UpdateDepartment(department);

                if (isUpdated)
                {
                    Console.WriteLine("Department updated Successfully");
                }

                else
                {
                    Console.WriteLine("Update Department Failed");
                }
            }
        }

        private static void DeleteEmployee()
        {
            int employeeId;
            do
            {
                Console.WriteLine("Enter empId to delete:");
            } while (!int.TryParse(Console.ReadLine(), out employeeId));
            Employee employee = EmsBL.GetEmployeeById(employeeId);
            if (employee == null)
            {
                Console.WriteLine("Employee does not exists:");
            }
            else
            {
                bool isDeleted = EmsBL.DeleteEmployee(employee);
                if (isDeleted)
                {
                    Console.WriteLine("Employee deleted");
                }
                else
                {
                    Console.WriteLine("Delete failed");
                }
            }
        }

        private static void UpdateEmployee()
        {
            int employeeId;
            do
            {
                Console.WriteLine("Enter empId to update:");
            } while (!int.TryParse(Console.ReadLine(),out employeeId));
            Employee employee = EmsBL.GetEmployeeById(employeeId);
            if (employee == null)
            {
                Console.WriteLine("Employee does not exists:");
            }
            else
            {
                
                string name;
                do
                {
                    Console.WriteLine("Enter employee name: ");
                    name = Console.ReadLine();
                } while (string.IsNullOrEmpty(name));
                employee.Name = name;

                DateTime dateOfJoining;
                string input;
                do
                {
                    Console.WriteLine("Enter Date of Joining (YYYY/MM/DD):");
                    input = Console.ReadLine();
                } while (!DateTime.TryParse(input, out dateOfJoining));
                employee.DateOfJoining = dateOfJoining;

                double salary;
                do
                {
                    Console.WriteLine("Enter employee salary");
                    input = Console.ReadLine();
                } while (!Double.TryParse(input, out salary));
                employee.Salary = salary;

                string email;
                do
                {
                    Console.WriteLine("Enter email:");
                    email = Console.ReadLine();
                } while (string.IsNullOrEmpty(email));
                employee.Mail = email;

                //Gender gender;
                do
                {
                    foreach (Gender item in Enum.GetValues(typeof(Gender)))
                    {
                        Console.WriteLine("{0}. {1}", (int)item, item);
                    }
                    input = Console.ReadLine();
                } while (Enum.IsDefined(typeof(Gender), input));
                employee.Gender = (Gender)Convert.ToInt32(input);


                string hobbies;
                do
                {
                    Console.WriteLine("Enter Hobbies:");
                    hobbies = Console.ReadLine();
                } while (string.IsNullOrEmpty(hobbies));
                employee.Hobbies = hobbies;

                int departmentId;
                do
                {
                    Console.WriteLine("Enter department id");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out departmentId));
                employee.DepartmentId = departmentId;

                bool isUpdated = EmsBL.UpdateEmployee(employee);
                if (isUpdated)
                {
                    Console.WriteLine("Employee updated");
                }
                else
                {
                    Console.WriteLine("Update failed");
                }
            }
        }

        private static void ListEmployees()
        {
            IEnumerable<Employee> employees = EmsBL.GetEmployeeList();
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        private static void AddEmployee()
        {
            Employee emp = new Employee();
            string name;
            do
            {
                Console.WriteLine("Enter employee name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            emp.Name = name;

            DateTime dateOfJoining;
            string input;
            do
            {
                Console.WriteLine("Enter Date of Joining (YYYY/MM/DD):");
                input = Console.ReadLine();
            } while (!DateTime.TryParse(input,out dateOfJoining));
            emp.DateOfJoining = dateOfJoining;

            double salary;
            do
            {
                Console.WriteLine("Enter employee salary");
                input = Console.ReadLine();
            } while (!Double.TryParse(input,out salary));
            emp.Salary = salary;

            string email;
            do
            {
                Console.WriteLine("Enter email:");
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email));
            emp.Mail = email;

            Gender gender;
            do
            {
                foreach (Gender item in Enum.GetValues(typeof(Gender)))
                {
                    Console.WriteLine("{0}. {1}",(int)item,item);
                }
                input = Console.ReadLine();
            } while (Enum.IsDefined(typeof(Gender),input));
            emp.Gender = (Gender)Convert.ToInt32(input);


            string hobbies;
            do
            {
                Console.WriteLine("Enter Hobbies:");
                hobbies = Console.ReadLine();
            } while (string.IsNullOrEmpty(hobbies));
            emp.Hobbies = hobbies;

            int departmentId;
            do
            {
                Console.WriteLine("Enter department id");
                input = Console.ReadLine();
            } while (!int.TryParse(input,out departmentId));
            emp.DepartmentId = departmentId;

            bool isAdded = EmsBL.AddEmployee(emp);
            if (isAdded)
            {
                Console.WriteLine("Employee added successfully");
            }
            else
            {
                Console.WriteLine("Employee add failed");
            }
        }

        private static void AddDepartment()
        {
            Department department = new Department();
            string name;
            do
            {
                Console.WriteLine("Enter department Name");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            department.Name = name;

            bool isAdded = EmsBL.AddDepartment(department);
            if (isAdded)
            {
                Console.WriteLine("Department added successfully");
            }
            else
            {
                Console.WriteLine("Department add failed");
            }

        }
    }
}
