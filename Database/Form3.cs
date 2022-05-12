using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;
using WindowsFormsApp.DAL;
using WindowsFormsApp.Model;

namespace Database
{

    
    public partial class Form3 : Form
    {
        StudentDal studal = new StudentDal();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.RollNo = Convert.ToInt32(txtRollNo.Text);
            stu.Name = txtName.Text;
            stu.Branch = txtBranch.Text;
            stu.Percentage = Convert.ToDouble(txtPercentage.Text);
           
            int res = studal.SaveStudent(stu);
            if (res == 1)
                MessageBox.Show("Inserted the record");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.RollNo = Convert.ToInt32(txtRollNo.Text);
            stu.Name = txtName.Text;
            stu.Branch = txtBranch.Text;
            stu.Percentage = Convert.ToDouble(txtPercentage.Text);

            int res = studal.UpdateStudent(stu);
            if (res == 1)
                MessageBox.Show("updated the record");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student stu  = studal.GetStudentByRoll(Convert.ToInt32(txtRollNo.Text));
            if (stu.RollNo> 0)
            {
                txtName.Text = stu.Name;
                txtBranch.Text = stu.Branch.ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = studal.DeleteStudent(Convert.ToInt32(txtRollNo.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            DataTable table = studal.GetAllStudents();
            dataGridView1.DataSource = table;
        }
    }
}
