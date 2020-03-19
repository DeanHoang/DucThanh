using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102170301_HoangDucThanh_17TCLC2.DTO;
using _102170301_HoangDucThanh_17TCLC2.GUI;
using _102170301_HoangDucThanh_17TCLC2.BLL;

namespace _102170301_HoangDucThanh_17TCLC2.GUI
{
    public delegate void AddNV(Employees emp);
    public delegate void UpdateNV(Employees em);
    public delegate void mydelegate();
   // public delegate Employees Loadmess(string id_emp, string name, bool gender, DateTime dt, string Id_dep);
    public delegate void ShowUpdate(string Id_em);
    //public delegate void delegateUpdate(string ID_Dep);
    public partial class DetailForm : Form
    {
        public AddNV addnv { get; set; }
        public UpdateNV updateNV { get; set; }
        public mydelegate del { get; set; }
        public ShowUpdate showup { get; set; }
        public QLNV ql { get; set; }
       // public Loadmess loadmess { get; set; }
        public DetailForm()
        {
            ql = new QLNV();
            InitializeComponent();
            showup += show;
        }
        bool CheckPK(string id_em)
        {            
            List<Employees> list = ql.Employs.Select(p => p).ToList();
            foreach (Employees i in list)
            {
                if (i.ID_Employee == id_em)
                    return true;
            }
            return false;
           
                        
        }
        private void show(string ID_emp)
        {
            try
            {
                tB_ID_Em.Enabled = false;
                var emp = ql.Employs.Select(p => new
                {
                    p.ID_Employee,
                    p.Name,
                    p.Gender,
                    p.Birthday,
                    p.ID_Dep
                }).Where(p => p.ID_Employee == ID_emp).FirstOrDefault();

                tB_ID_Em.Enabled = false;
                tB_ID_Em.Text = emp.ID_Employee;
                tB_Name.Text = emp.Name;
                dt_Birthday.Value = emp.Birthday;
                if (emp.Gender == true) rB_Male.Checked = true;
                else rB_Female.Checked = true;
                cbb_ID_Dep.Text = emp.ID_Dep;
            }catch(Exception e)
            { MessageBox.Show(e.Message); }
       
        }
        private void bt_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Employees emp = new Employees();
                emp.ID_Employee = tB_ID_Em.Text;
                emp.ID_Dep = cbb_ID_Dep.Items[cbb_ID_Dep.SelectedIndex].ToString();
                emp.Name = tB_Name.Text;
                if (rB_Male.Checked) emp.Gender = true;
                else emp.Gender = false;
                emp.Birthday = Convert.ToDateTime(dt_Birthday.Value.ToString());
                if (CheckPK(tB_ID_Em.Text) == false)
                {
                    this.addnv(emp);

                }
                else
                {
                    this.updateNV(emp);
                }
                this.del();
                this.Dispose();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
