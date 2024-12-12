using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace lab9demo
{
    internal class Lecturer
    {
        private string studName;
        private string email;
        private string phoneNum;
        private string tpnumber;
        private string address;
        private string level;
        private string month;
        private string modules;
        private string lecturer_email;
        private string lecturer_phoneNum;
        private string name;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string StudName { get => studName; set => studName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Tpnumber { get => tpnumber; set => tpnumber = value; }
        public string Address { get => address; set => address = value; }
        public string Level { get => level; set => level = value; }
        public string Month { get => month; set => month = value; }
        public string Modules { get => modules; set => modules = value; }
        public string Lecturer_email { get => lecturer_email; set => lecturer_email = value; }
        public string Lecturer_phoneNum { get => lecturer_phoneNum; set => lecturer_phoneNum = value; }
        public string Name { get => name; set => name = value; }

        public Lecturer(string sn, string e, string num, string tp, string a, string l, string m, string ms, string le, string lp)
        {
            studName = sn;
            email = e;
            phoneNum = num;
            tpnumber = tp;
            address = a;
            level = l;
            month = m;
            modules = ms;
            Lecturer_email = le;
            Lecturer_phoneNum = lp;
        }

        public Lecturer(string n)
        {
            name = n;
        }
        public string AddStudent()
        {
            string status;
            con.Open();

            // Check if a student record already exists with the given tpnumber
            if (IsStudentRecordExist(tpnumber))
            {
                con.Close();
                return "Student record already exists. Check student name and tpnumber.";
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO students (studentName, email, phoneNumber, tpnumber, address, level, month, modules) VALUES (@name, @em, @um, @tp, @addr, @lvl, @month, @modules)", con);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO users (username, password, role) VALUES (@name, '123', 'student')", con);
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

        public void UpdateStudent(string studentName, string email, string phoneNumber, string tpnumber, string address, string level, string month, string modules)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE students SET email=@email, phoneNumber=@phoneNumber, studentName=@studentName, address=@address, level=@level, month=@month, modules=@modules WHERE tpnumber=@tpnumber", con);
            cmd.Parameters.AddWithValue("@studentName", studentName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@tpnumber", tpnumber);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@modules", modules);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteStudent(string studentName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE tpnumber=@tpnumber", con);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM users WHERE username=@studentName", con);
            cmd.Parameters.AddWithValue("@tpnumber", studentName);
            cmd2.Parameters.AddWithValue("@studentName", studentName);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public DataTable SearchStudent(string studentName, string email, string phoneNumber, string tpnumber, string address, string level, string month, string modules)
        {
            DataTable dt = new DataTable();
            string query = "SELECT studentName, email, phoneNumber, tpnumber, address, level, month, modules FROM students WHERE 1 = 1";
            SqlCommand cmd = new SqlCommand(query, con);

            if (!string.IsNullOrWhiteSpace(studentName))
            {
                query += " AND studentName LIKE @StudentName";
                cmd.Parameters.AddWithValue("@StudentName", "%" + studentName + "%");
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query += " AND email LIKE @Email";
                cmd.Parameters.AddWithValue("@Email", "%" + email + "%");
            }

            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                query += " AND phoneNumber LIKE @PhoneNumber";
                cmd.Parameters.AddWithValue("@PhoneNumber", "%" + phoneNumber + "%");
            }

            if (!string.IsNullOrWhiteSpace(tpnumber))
            {
                query += " AND tpnumber LIKE @Tpnumber";
                cmd.Parameters.AddWithValue("@Tpnumber", "%" + tpnumber + "%");
            }

            if (!string.IsNullOrWhiteSpace(address))
            {
                query += " AND address LIKE @Address";
                cmd.Parameters.AddWithValue("@Address", "%" + address + "%");
            }

            if (!string.IsNullOrWhiteSpace(level))
            {
                query += " AND level = @Level";
                cmd.Parameters.AddWithValue("@Level", level);
            }

            if (!string.IsNullOrWhiteSpace(month))
            {
                query += " AND month LIKE @Month";
                cmd.Parameters.AddWithValue("@Month", "%" + month + "%");
            }

            if (!string.IsNullOrWhiteSpace(modules))
            {
                query += " AND modules LIKE @Modules";
                cmd.Parameters.AddWithValue("@Modules", "%" + modules + "%");
            }

            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetAllStudents()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT studentName, email, phoneNumber, tpnumber, address, level, month, modules FROM students", con);
                da.Fill(dt);
                return dt;
            }
        }
        public static ArrayList viewAll()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select modules from students", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewStudentName()
        {
            ArrayList ln = new ArrayList();

            con.Open();

            SqlCommand cmd = new SqlCommand("select studentName from students", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ln.Add(rd.GetString(0));
            }
            con.Close();
            return ln;
        }
        public void ApproveModule(string studentName, string module)
        {
            studName = studentName;
            modules = module;

            con.Open();

            // Retrieve the existing modules for the student
            SqlCommand retrieveCmd = new SqlCommand("SELECT modules FROM students WHERE studentName=@studentName", con);
            retrieveCmd.Parameters.AddWithValue("@studentName", studentName);
            string existingModules = retrieveCmd.ExecuteScalar()?.ToString();

            // Append the new module to the existing modules
            string updatedModules = existingModules + ", " + module;

            // Update the students table with the updated modules
            SqlCommand updateCmd = new SqlCommand("UPDATE students SET modules=@modules WHERE studentName=@studentName", con);
            updateCmd.Parameters.AddWithValue("@studentName", studentName);
            updateCmd.Parameters.AddWithValue("@modules", updatedModules);
            updateCmd.ExecuteNonQuery();

            // Delete the request from the requests table
            SqlCommand deleteCmd = new SqlCommand("DELETE FROM requests WHERE studentName=@studentName AND modules=@modules", con);
            deleteCmd.Parameters.AddWithValue("@studentName", studentName);
            deleteCmd.Parameters.AddWithValue("@modules", module);
            deleteCmd.ExecuteNonQuery();

            con.Close();
        }
        public void DeclineRequest(string studentName, string selectModule)
        {
            studName = studentName;
            modules = selectModule;

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM requests WHERE studentName=@studentName AND modules=@modules", con);
            cmd.Parameters.AddWithValue("@studentName", studentName);
            cmd.Parameters.AddWithValue("@modules", modules);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static ArrayList viewModuleName(string studentName)
        {
            ArrayList mn = new ArrayList();

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT modules FROM requests WHERE studentName=@studentName", con);
            cmd.Parameters.AddWithValue("@studentName", studentName);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mn.Add(rd.GetString(0));
            }
            con.Close();
            return mn;
        }
        public static bool IsModuleRequested(string studentName, string modules)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM requests WHERE studentName=@studentName AND modules=@modules", con);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@modules", modules);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count > 0;
            }
        }
        public DataTable GetModuleNames()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT module_name FROM modules", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
        public DataTable GetLevelNames()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT level_name FROM levels", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
        public bool IsStudentRecordExist(string tpnumber)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM students WHERE tpnumber=@tpnumber", con);
            cmd.Parameters.AddWithValue("@tpnumber", tpnumber);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
        }
        public static ArrayList viewStudentNameFromRequests()
        {
            ArrayList ln = new ArrayList();

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT studentName FROM requests", con); // Retrieve student names from requests datatable
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ln.Add(rd.GetString(0));
            }
            con.Close();
            return ln;
        }
        public static void viewProfile(Lecturer o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from lecturers where name = '" + o1.name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.phoneNum = rd.GetString(3);
            }
            con.Close();
        }
        public string updateProfile(string le, string lp)
        {
            string status;
            con.Open();

            Lecturer_email = le;
            Lecturer_phoneNum = lp;

            SqlCommand cmd = new SqlCommand();

            // Check if both email and phone number are blank
            if (string.IsNullOrWhiteSpace(Lecturer_email) && string.IsNullOrWhiteSpace(Lecturer_phoneNum))
            {
                con.Close();
                return "Both email and phone fields are blank. Please enter a value for at least one field.";
            }

            // Update the query and parameters based on the values provided
            string updateQuery = "UPDATE lecturers SET ";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(Lecturer_email) && Lecturer_email != email)
            {
                updateQuery += "email = @email";
                parameters.Add(new SqlParameter("@email", Lecturer_email));
            }

            if (!string.IsNullOrWhiteSpace(Lecturer_phoneNum) && Lecturer_phoneNum != phoneNum)
            {
                if (parameters.Count > 0)
                    updateQuery += ", ";
                updateQuery += "phoneNum = @phoneNum";
                parameters.Add(new SqlParameter("@phoneNum", Lecturer_phoneNum));
            }

            updateQuery += " WHERE name = @name";

            cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@name", name);

            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }

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