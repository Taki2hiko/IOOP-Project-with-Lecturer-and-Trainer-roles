using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9demo
{
    internal class Coach_Info
    {
        private string module_name, charge, class_schedule;
        private string trainer_name, trainer_email, phone_number;
        private string password;
        private string trainer_feedback;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Trainer_name { get => trainer_name; set => trainer_name = value; }
        public string Trainer_email { get => trainer_email; set => trainer_email = value; }
        public string Phone_num { get => phone_number; set => phone_number = value; }

        public Coach_Info(string trainer_name)
        {
            this.trainer_name = trainer_name;
        }

        public Coach_Info(string mn, string c, string cs, string tn, string te, string pn, string pw, string fb)
        {
            module_name = mn;
            charge = c;
            class_schedule = cs;
            trainer_name = tn;
            trainer_email = te;
            phone_number = pn;
            password = pw;
            trainer_feedback = fb;
        }

        public Coach_Info()
        {

        }
        public static void ProfileViewing(Coach_Info pv)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from trainers where trainer_name = @trainerName", con);
            cmd.Parameters.AddWithValue("@trainerName", pv.trainer_name);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                pv.trainer_name = rd.GetString(1);
                pv.trainer_email = rd.GetString(2);

                if (!rd.IsDBNull(4))
                    pv.phone_number = rd.GetString(4);
                else
                    pv.phone_number = ""; // or any other default value you prefer
            }

            con.Close(); ;
        }

        public string AddCoachInfo(string mn, string c, string cs)
        {
            string status;
            con.Open();
            module_name = mn;
            charge = c;
            class_schedule = cs;

            SqlCommand cmd = new SqlCommand("INSERT INTO modules(module_name, charge, class_schedule) VALUES(@modname, @charges, @cs)", con);
            cmd.Parameters.AddWithValue("@modname", module_name);
            cmd.Parameters.AddWithValue("@charges", charge);
            cmd.Parameters.AddWithValue("@cs", class_schedule);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();
            return status;
        }

        public void UpdateCoachInfo(string module_name, string charge, string class_schedule)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE modules SET module_name=@module_name, charge=@charge, class_schedule=@class_schedule", con);
            cmd.Parameters.AddWithValue("@module_name", module_name);
            cmd.Parameters.AddWithValue("@charge", charge);
            cmd.Parameters.AddWithValue("@class_schedule", class_schedule);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCoachInfo(string module_name, string charge, string class_schedule)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM modules WHERE module_name=@module_name OR charge=@charge OR class_schedule=@class_schedule", con);
            cmd.Parameters.AddWithValue("@module_name", module_name);
            cmd.Parameters.AddWithValue("@charge", charge);
            cmd.Parameters.AddWithValue("@class_schedule", class_schedule);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string TrainerProfUpdate(string em, string pn, string pw)
        {
            string status;
            con.Open();
            trainer_email = em;
            phone_number = pn;
            password = pw;

            SqlCommand cmd = new SqlCommand("update trainers set trainer_email ='" + trainer_email + "',phone_number='" + phone_number + "'where trainer_name ='" + trainer_name + "'", con);
            SqlCommand cmd1 = new SqlCommand("update users set password ='" + password + "'where username='" + trainer_name + "'", con);

            int i = cmd.ExecuteNonQuery();
            int j = cmd1.ExecuteNonQuery();

            if (i != 0 && j != 0)
                status = "Updated!";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public string SendFeedback(string tn, string fb)
        {
            string status;
            con.Open();
            trainer_name = tn;
            trainer_feedback = fb;
            SqlCommand cmd = new SqlCommand("INSERT INTO feedback(trainer_name, trainer_feedback) VALUES(@trainer_name, @trainer_feedback)", con);
            cmd.Parameters.AddWithValue("@trainer_name", trainer_name);
            cmd.Parameters.AddWithValue("@trainer_feedback", trainer_feedback);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Sent!";
            else
                status = "Unable to send.";
            con.Close();
            return status;
        }

        public DataTable DataGridRetrive()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from modules", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable DataGridRetrive2()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from charges", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
        }
    }
}
