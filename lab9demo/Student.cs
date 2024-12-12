using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab9demo
{
    internal class Student
    {
        private string studName;
        private string email;
        private string phoneNum;
        private string tpnumber;
        private string address;
        private string level;
        private string month;
        private string modules;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Tpnumber { get => tpnumber; set => tpnumber = value; }
        public string Level { get => level; set => level = value; }
        public string Address { get => address; set => address = value; }
        public string Month { get => month; set => month = value; }
        public string Modules { get => modules; set => modules = value; }

        public Student(string n, string e, string num, string tp, string a, string l, string m, string ms)
        {
            studName = n;
            email = e;
            phoneNum = num;
            tpnumber = tp;
            address = a;
            level = l;
            month = m;
            modules = ms;
        }

        public Student(string n)
        {
            studName = n;
        }

        public string addStudent()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into students(studentName,email, phoneNumber, tpnumber, address, level, month, modules) values(@name,@em, @um, @tp, @addr, @lvl, @month, @modules)", con);
            //below is logic to prevent duplicate username registration for login
            /*
            select count(*) from users where username = @name
            if the count > @ , that means username already exist,
            thus you should show error msg

            else execute insert into statement (cmd2)
            */

            SqlCommand cmd2 = new SqlCommand("insert into users (username,password,role) values(@name,'123','student')", con);
            cmd.Parameters.AddWithValue("@name", studName);
            cmd2.Parameters.AddWithValue("@name", studName);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@um", phoneNum);
            cmd.Parameters.AddWithValue("@tp", tpnumber);
            cmd.Parameters.AddWithValue("@addr", address);
            cmd.Parameters.AddWithValue("@lvl", level);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@modules", modules);

            cmd2.ExecuteNonQuery();
            var i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();
            return status;
        }
        public static ArrayList viewAll()
        {
            //arraylist to create dynamic array
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select studentName from students", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));//add element into arraylist
            }
            con.Close();
            return nm;
        }
        public static void viewProfile(Student o1) //receive object of class Student as paramater
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName = '" + o1.studName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.phoneNum = rd.GetString(3);
                o1.tpnumber = rd.GetString(4);
                o1.address = rd.GetString(5);
                o1.level = rd.GetString(6);
                o1.month = rd.GetString(7);
                o1.modules = rd.GetString(8);
            }
            con.Close();

        }
        public string updateProfile(string em, string num)
        {
            string status;
            con.Open();

            email = em;
            phoneNum = num;

            SqlCommand cmd = new SqlCommand("update students set email=@email, phoneNumber=@phoneNum where studentName = @studName", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successful.";
            else
                status = "Unable to update.";

            con.Close();
            return status;
        }
        public string updateModule(string ms)
        {
            string status;
            con.Open();

            modules = ms;

            SqlCommand cmd = new SqlCommand("update students set modules=@modules", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successful.";
            else
                status = "Unable to update.";

            con.Close();
            return status;
        }
    }
}
