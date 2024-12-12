using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9demo
{
    internal class User
    {
        private string username;
        private string password;

        public User(string u, string p)
        {
            username = u;
            password = p;
        }

        public string login(string un)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username + "' and password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username='" + username + "' and password = '" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    AdminHome a = new AdminHome(un);
                    a.ShowDialog();
                }

                else if (userRole == "student")
                {
                    StudentHome s = new StudentHome(un);
                    s.ShowDialog();
                }

                else if (userRole == "trainer")
                {
                    TrainerHome t = new TrainerHome(un);
                    t.ShowDialog();
                }

                else if (userRole == "lecturer")
                {
                    LecturerHome l = new LecturerHome(un);
                    l.ShowDialog();
                }

            }
            else
                status = "Incorrect username/password";
            con.Close();

            return status;
        }
    }
}
