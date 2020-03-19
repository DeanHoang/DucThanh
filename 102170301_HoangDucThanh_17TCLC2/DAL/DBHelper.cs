using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170301_HoangDucThanh_17TCLC2.DAL
{
    public class DBHelper
    {
        public QLNV ql { get; set; }
        public DBHelper()
        {
            ql = new QLNV();
        }
    }
}
