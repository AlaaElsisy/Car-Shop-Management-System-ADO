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
using Microsoft.VisualBasic.ApplicationServices;

namespace prsentation
{
    public partial class adminProfile : Form
    {
        private int _userId;
        Users user;
        public adminProfile(int userId)
        {
            _userId = userId;

            user = new Users(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            InitializeComponent();
        }



        private void adminProfile_Load(object sender, EventArgs e)
        {
            DataTable dt = user.get_users_by_id(_userId);
            txt_username.Text = dt.Rows[0]["Username"].ToString();
            // txt_email.Text = dt.Rows[0]["Email"].ToString();
            txt_age.Text = dt.Rows[0]["Age"].ToString();
            txt_add.Text = dt.Rows[0]["Address"].ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataTable dt = user.get_users_by_id(_userId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found.");
                return;
            }

            string role = dt.Rows[0]["Role"].ToString();
            string oldpass = dt.Rows[0]["Password"].ToString();

            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
     string.IsNullOrWhiteSpace(txt_newpass.Text) ||
     string.IsNullOrWhiteSpace(txt_age.Text) ||
     string.IsNullOrWhiteSpace(txt_add.Text) ||
     string.IsNullOrWhiteSpace(txt_oldpass.Text) ||
     string.IsNullOrWhiteSpace(txt_confirmpass.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }


            if (txt_oldpass.Text != oldpass)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }

            if (txt_newpass.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!int.TryParse(txt_age.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }

            if (txt_newpass.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
                return;
            }

            if (age < 18 || age > 100)
            {
                MessageBox.Show("Age must be between 18 and 100.");
                return;
            }

            int rows = user.update_user(_userId, txt_username.Text, txt_newpass.Text, age, txt_add.Text, role);

            if (rows > 0)
            {
                MessageBox.Show("User updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            //txt_add.Text = "";
            //txt_age.Text = "";
            txt_confirmpass.Text = "";
            txt_newpass.Text = "";
            txt_oldpass.Text = "";
            // txt_username.Text = "";



        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            adminedit_products products = new adminedit_products(_userId);
            products.Show();
        }

        private void btn_edituser_Click(object sender, EventArgs e)
        {
            this.Close();
            adminEditeUsers users = new adminEditeUsers(_userId);
            users.Show();
        }

        private void btn_editcatiegors_Click(object sender, EventArgs e)
        {
            this.Close();
            admineditcategories categories = new admineditcategories(_userId);
            categories.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_oldpass.UseSystemPasswordChar)
            {
                txt_oldpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_oldpass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_newpass.UseSystemPasswordChar)
            {
                txt_newpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_newpass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txt_confirmpass.UseSystemPasswordChar)
            {
                txt_confirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_confirmpass.UseSystemPasswordChar = true;
            }

        }
    }
}
