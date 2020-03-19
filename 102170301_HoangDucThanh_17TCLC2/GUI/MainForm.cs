using _102170301_HoangDucThanh_17TCLC2.BLL;
using _102170301_HoangDucThanh_17TCLC2.DTO;
using _102170301_HoangDucThanh_17TCLC2.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102170301_HoangDucThanh_17TCLC2
{
    public partial class Form1 : Form
    {      
        public mydelegate del { get; set; }
        public BLL_QL bll { get; set; }
        public Form1()
        {
            bll = new BLL_QL();
            InitializeComponent();
        }

        public void show()
        {
            dataGridView1.DataSource = bll.GetList();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DetailForm df = new DetailForm();
                df.addnv += add;
                df.updateNV += update;
                df.del += show;
                df.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID_Employee"].Value.ToString();
                DetailForm df = new DetailForm();
                df.showup(id);
                df.updateNV += update;
                df.del += show;
                df.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
                foreach (DataGridViewRow i in d)
                    bll.Delele(i.Cells[0].Value.ToString());
                dataGridView1.DataSource = bll.GetList();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string GetInfo(string ID_Em)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            return dataGridView1.Rows[index].Cells[0].Value.ToString();
            
        }
        public void add(Employees emp)
        {
            bll.Add(emp);
        }
        public void update(Employees emp)
        {
            bll.Update(emp);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) dataGridView1.DataSource = bll.GetListCBB("2");
            else dataGridView1.DataSource = bll.GetListCBB("1");
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = bll.GetList();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public delegate bool Compare(object o1, object o2);
       
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            List<Employees> listnv = new List<Employees>();
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                listnv.Add(bll.GetNV(dataGridView1.Rows[i].Cells["ID_Employee"].Value.ToString()));
            }
            dataGridView1.DataSource = bll.Sort(listnv.ToArray(),Employees.CompareName);
        }
    }
}
