using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace firstdbform
{
    public partial class Form3insert : Form
    {
        db mydb = new db();
        public Form3insert()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            string first = txtfirst.Text.Trim();
            string last = txtlast.Text.Trim();
            string emails = txtemail.Text.Trim();
            int age = Convert.ToInt32(txtage.Text);
            mydb.insert(first, last, emails, age);
            MessageBox.Show("inserted into patient record");
            

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
