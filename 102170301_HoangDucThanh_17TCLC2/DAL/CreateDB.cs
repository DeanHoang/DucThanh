using _102170301_HoangDucThanh_17TCLC2.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170301_HoangDucThanh_17TCLC2.DAL
{
    public class CreateDB: CreateDatabaseIfNotExists<QLNV>
    {
        protected override void Seed(QLNV context)
        {
            context.Employs.Add(new Employees { ID_Employee = "1", Name = "Thanh", Gender = true, Birthday = Convert.ToDateTime("1/1/1900"), ID_Dep = "1" });
            context.Employs.Add(new Employees { ID_Employee = "2", Name = "Thanh3", Gender = false, Birthday = Convert.ToDateTime("1/11/1900"), ID_Dep = "2" });
            context.Employs.Add(new Employees { ID_Employee = "3", Name = "Thanh2", Gender = true, Birthday = Convert.ToDateTime("1/1/1999"), ID_Dep = "1" });
            context.Departs.Add(new Departments { ID_Dep = "1", Name_Dep = "Phong Hanh Chinh" });
            context.Departs.Add(new Departments { ID_Dep = "2", Name_Dep = "Phong Nhan Su" });
        }
    }
}
