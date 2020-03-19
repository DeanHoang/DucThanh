using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170301_HoangDucThanh_17TCLC2.DTO
{
    public class Departments
    {
        [Key][Required]
        public string ID_Dep { get; set; }

        public string Name_Dep { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }        
    }
}
