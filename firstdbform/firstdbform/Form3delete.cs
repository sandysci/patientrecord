using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace firstdbform
{
    public partial class Form3delete : Form
    {
        db mydb = new db();
        public Form3delete()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string first = txtdel.Text.Trim();
            if (string.IsNullOrWhiteSpace(first))
            {
                MessageBox.Show("cant be empty");

            }
            else if (Regex.IsMatch(first, @"[a-zA-Z]"))
            {
                mydb.delete(first);

                txtdel.Text = "";


            }
            else
            {
                MessageBox.Show("Enter a valid input");
                txtdel.Text = "";
            }
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
