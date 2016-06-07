using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace firstdbform
{
    public class db
    {
        public MySqlConnection mycon;
        MySqlCommand cmd = new MySqlCommand();
        persons p = new persons();
        public void connection()
        {

            string con = "Server = 127.0.0.1; username = root; password = sandyy11; database = hospital; ";
            mycon = new MySqlConnection(con);
            try
            {
                mycon.Open();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        public void closeconnection()
        {
            try
            {
                mycon.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
        public void insert(string first, string last, string emails, int age)
        {
            connection();
            string query = "INSERT INTO patient VALUES('','" + first + "','" + last + "','" + emails + "','" + age + "')";

            cmd.CommandText = query;
            cmd.Connection = mycon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted into patient record");
            closeconnection();


        }
        public void delete(string first)
        {
            connection();
            string query = "DELETE FROM patient WHERE firstname='" + first + "' ";
            cmd.CommandText = query;
            cmd.Connection = mycon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted ");


            closeconnection();


        }
        public List<persons> fetch(string first1)
        {
            List<persons> mylist = new List<persons> { };
            connection();
            string query = "SELECT * FROM patient WHERE firstname ='" + first1 + "'";
            cmd.CommandText = query;
            cmd.Connection = mycon;
            // cmd.Parameters.Add("firstname", SqlDbType.VarChar).Value = first1;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                p.id = (reader["ID"].ToString());
                p.firstname = (reader["firstname"].ToString());
                p.lastname = (reader["lastname"].ToString());
                p.email = (reader["email"].ToString());
                p.age = (reader["age"].ToString());

                mylist.Add(p);


            }

            return mylist;
        }


        public void update(string first, string last, string email, int age, string id)
        {

            connection();
            string query = "UPDATE patient SET firstname='" + first + "',lastname='" + last + "',email='" + email + "',age='" + age + "'WHERE  ID='" + id + "' ";
            cmd.CommandText = query;
            cmd.Connection = mycon;
            cmd.ExecuteNonQuery();
            closeconnection();




        }

    }
}
