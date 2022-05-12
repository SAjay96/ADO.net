using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.DAL;
using WindowsFormsApp.Model;

namespace Database
{
    public partial class Form2 : Form
    {
        EmpDal empdal = new EmpDal();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            emp.DeptName = txtDeptName.Text;
            int res = empdal.Save(emp);
            if (res == 1)
                MessageBox.Show("Inserted the record");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Id = Convert.ToInt32(txtId.Text);
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            emp.DeptName = txtDeptName.Text;

            int res = empdal.Upate(emp);
            if (res == 1)
                MessageBox.Show("updated the record");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Emp emp = empdal.GetEmpById(Convert.ToInt32(txtId.Text));
            if (emp.Id > 0)
            {
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = empdal.Delete(Convert.ToInt32(txtId.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable table = empdal.GetAllEmps();
            dataGridView1.DataSource = table;
        }
    }
}
