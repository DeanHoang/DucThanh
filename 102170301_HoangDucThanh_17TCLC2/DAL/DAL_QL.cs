using _102170301_HoangDucThanh_17TCLC2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102170301_HoangDucThanh_17TCLC2.DAL
{
    public class DAL_QL
    {
        public DBHelper db { get; set; }
        public DAL_QL()
        {
            db = new DBHelper();
        }
        public IList Show()
        {
            return db.ql.Employs.Select(p => new { p.ID_Employee, p.Name, p.Gender, p.Birthday, p.ID_Dep, p.Departments.Name_Dep }).ToList();
        }   
        public void Delete(string id)
        {
            Employees emp = db.ql.Employs.Where(p => p.ID_Employee == id).SingleOrDefault();
            db.ql.Employs.Remove(emp);
            db.ql.SaveChanges();
        }
        public void Add(Employees emp)
        {
            var Id_em = db.ql.Employs.Where(p => p.ID_Dep == emp.ID_Dep).Select(p => p.ID_Employee).FirstOrDefault();
            Employees emp_add = new Employees()
            {
                ID_Employee = emp.ID_Employee,
                Name = emp.Name,
                Birthday = emp.Birthday,
                ID_Dep = Id_em,
                Gender = emp.Gender,
            };
            db.ql.Employs.Add(emp_add);
            db.ql.SaveChanges();
        }
        public IList GetListCBB(string Id_dep)
        {
            var list = db.ql.Employs.Where(p => p.ID_Dep == Id_dep).Select
                (p => new { p.ID_Employee, p.Name, p.Gender, p.Birthday, p.ID_Dep, p.Departments.Name_Dep }).ToList();
            return list;

        }
        public void Update(Employees emp)
        {
            var id = db.ql.Employs.Where(p => p.ID_Employee == emp.ID_Employee).Select(p => p.ID_Employee).FirstOrDefault();
            var emp_update = db.ql.Employs.Select(p => p).Where(p => p.ID_Employee == id).FirstOrDefault();
            emp_update.Name = emp.Name;
            emp_update.Gender = emp.Gender;
            emp_update.Birthday = emp.Birthday;
            emp_update.ID_Dep = emp.ID_Dep;
            emp_update.ID_Employee = id;
            db.ql.SaveChanges();

        }
        public Employees GetNV(string id)
        {
            Employees emp = new Employees();
            emp = db.ql.Employs.Where(p => p.ID_Employee == id).FirstOrDefault();
            return emp;
        }
    }
}
