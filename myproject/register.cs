using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using businessLogic;

namespace prsentation
{
    public partial class register : Form
    {
        Users user;

        public register()
        {
            user = new Users(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            InitializeComponent();
        }

        //private void btn_register_Click(object sender, EventArgs e)
        //{

        //    int rows = user.add_user(txt_username.Text, txt_pass.Text, txt_email.Text, Convert.ToInt32(num_age.Value), txt_add.Text, "User");
        //    if (rows > 0)
        //    {
        //        MessageBox.Show("User added successfully");
        //    }
        //    else
        //    {
        //        MessageBox.Show("User not added");
        //    }



        //}


        private void btn_register_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text.Trim().ToLower();
            string password = txt_pass.Text.Trim().ToLower();
            string email = txt_email.Text.Trim().ToLower();
            int age = Convert.ToInt32(num_age.Value);
            string address = txt_add.Text.Trim().ToLower();


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields are required.");
                return;
            }


            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
                return;
            }


            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            if (age < 18 || age > 100)
            {
                MessageBox.Show("Age must be between 18 and 100.");
                return;
            }
            if (user.check_email(email))
            {
                MessageBox.Show("Email already exists.");
                return;

            }


            int rows = user.add_user(username, password, email, age, address, "User");

            if (rows > 0)
            {
                MessageBox.Show("User added successfully.");
            }
            else
            {
                MessageBox.Show("User not added.");
            }
            int id = user.getuserid(email);
            this.Close();
            userProfile u = new userProfile(id);
            u.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }

        }
    }
}
