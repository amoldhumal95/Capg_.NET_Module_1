using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public string Hobbies { get; set; }
        public int DepartmentId { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}   Name: {Name}    Date of Joining: {DateOfJoining.ToShortDateString()}    \nSalary: {Salary}    Email : {Mail}  Gender : {Gender}   \nHobbies : {Hobbies}     DepartmentId : {DepartmentId}"; 
        }
    }
}
