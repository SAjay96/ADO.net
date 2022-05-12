using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using WindowsFormsApp.Model;
using System.Data;

namespace WindowsFormsApp
{
    public class StudentDal
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public StudentDal()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        public Student GetStudentByRoll(int roll)
        {
            Student stu = new Student();
            string qry = "select * from Student where Roll=@roll";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@roll", roll);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows) // existance of record in dr object
            {
                while (dr.Read())
                {
                    stu.RollNo = Convert.ToInt32(dr["Roll"]);
                    stu.Name = dr["Name"].ToString();// ["Name"] should match col name
                    stu.Branch =dr["Branch"].ToString();
                    stu.Percentage = Convert.ToInt32(dr["Percentage"]);
                }
            }
            con.Close();
            return stu;
        }
        public int SaveStudent(Student stu)
        {

            string qry = "insert into Student values(@Rollno,@name,@price)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Rollno", stu.RollNo);
            cmd.Parameters.AddWithValue("@name", stu.Name);
            cmd.Parameters.AddWithValue("@price", stu.Branch); 
            cmd.Parameters.AddWithValue("@price", stu.Percentage);

            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateStudent(Student stu)
        {

            string qry = "update Student set Name=@name,Branch=@branch where Roll=@roll";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Rollno", stu.RollNo);
            cmd.Parameters.AddWithValue("@name", stu.Name);
            cmd.Parameters.AddWithValue("@price", stu.Branch);
            cmd.Parameters.AddWithValue("@price", stu.Percentage);

            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int DeleteStudent(int id)
        {
            string qry = "delete from Student where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public DataTable GetAllStudents()
        {
            DataTable table = new DataTable();
            string qry = "select * from Student";
            cmd=new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            table.Load(dr);
            con.Close();
            return table;
        }

    }
}
