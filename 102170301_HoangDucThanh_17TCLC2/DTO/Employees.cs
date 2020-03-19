using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170301_HoangDucThanh_17TCLC2.DTO
{
    public class Employees
    {
        [Key]
        [Required]
        public string ID_Employee { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string ID_Dep { get; set; }
        [ForeignKey("ID_Dep")]

        public virtual Departments Departments { get; set; }

        public static bool CompareName(object o1,object o2)
        {
            if (String.Compare(((Employees)o1).Name, ((Employees)o2).Name) > 0) return true;
            else return false;
        }
    }
}
