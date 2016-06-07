using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace firstdbform
{
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

   
    public partial class patientform :Form 
    {
        db mydb = new db();
        persons myp = new persons();
     
        public patientform()
        {
            InitializeComponent();
        }

        private void btnsearchrecord_Click(object sender, EventArgs e)
        {
            string firstt = txttesting.Text;
            List<persons> myl = mydb.fetch(firstt);
         
            foreach (var i in myl)
            {
                groupupdate.Visible = true;
                txtfirst2.Text = i.firstname;
                txtlast2.Text = i.lastname;
                txtemail2.Text = i.email;
                txtage2.Text = i.age;
            }
            txttesting.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string firstt = txttesting.Text;
            string first = txtfirst2.Text;
            string last = txtlast2.Text;
            string email = txtemail2.Text;
           int ages = Convert.ToInt32(txtage2.Text);
            List<persons> myll = mydb.fetch(firstt);
            foreach (var k in myll){
                
                mydb.update(first, last, email, ages,k.id);
            
            }
             MessageBox.Show("updated");

            txtfirst2.Text = "";
            txtlast2.Text = "";
            txtemail2.Text = "";
            txtage2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myf = new Form2();
            this.Hide();
            myf.ShowDialog();
            this.Close();
        }
   
    }

    }


