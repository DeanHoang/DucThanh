using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102170301_HoangDucThanh_17TCLC2.DAL;
using _102170301_HoangDucThanh_17TCLC2.DTO;

namespace _102170301_HoangDucThanh_17TCLC2.BLL
{
    public class BLL_QL
    {
        public DAL_QL dal { get; set; }
        public BLL_QL()
        {
            dal = new DAL_QL();
        }
        public IList GetList()
        {
           return dal.Show();
        }
        public void Delele(string id)
        {
            dal.Delete(id);
        }
        public void Add(Employees emp)
        {
            dal.Add(emp);
        }
        public void Update(Employees emp)
        {
            dal.Update(emp);
        }
        public IList GetListCBB(string Id_dep)
        {
           return dal.GetListCBB(Id_dep);
        }
        public delegate bool Compare(object o1, object o2);
        public object[] Sort(object[] o, Compare comp)
        {
            for (int i = 0; i < o.Length; i++)
                for (int j = 0; j < o.Length; j++)
                {
                    if (comp(o[i], o[j]))
                    {
                        object tam;
                        tam = o[i];
                        o[i] = o[j];
                        o[j] = tam;
                    }
                }
            return o;
        }
        public Employees GetNV(string id)
        {
            return dal.GetNV(id);
        }
    }
}
