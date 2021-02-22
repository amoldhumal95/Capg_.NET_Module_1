using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public override string ToString()
        {
            return $"Department Id : {Id}   Department Name : {Name}";
        }
    }
}
