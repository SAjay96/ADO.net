using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=AJAY\SQLEXPRESS01;database=ThinkQ;Integrated Security=True");
        }
        public void ClearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                string qry = "insert into Product values(@id,@name,@price)";
               
                cmd = new SqlCommand(qry, con);
               
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
              
                con.Open();
              
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearAll(); 
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows) // existance of record in dr object
                {
                    while (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();// ["Name"] should match col name
                        txtPrice.Text = reader["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "update Product set Name=@name,Price=@price where Id=@id";

                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));

                con.Open();

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record updated");
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                string qry = "delete from Product where Id=@id";

                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
               

                con.Open();

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(Id) from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value) // when obj is null or obj does not have value
                {
                    txtId.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtId.Text = id.ToString();
                }

                txtId.Enabled = false;
                txtName.Clear();
                txtPrice.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows) // existance of record in  object
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    DataGrid.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void DataGrid_Click(object sender, EventArgs e)
        {
            txtId.Text =DataGrid.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

