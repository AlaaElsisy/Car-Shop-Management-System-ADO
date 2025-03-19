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
    public partial class adminEditeUsers : Form
    {
        private int _userId;
        Users user;
        public adminEditeUsers(int userId)
        {
            _userId = userId;

            user = new Users(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);

            InitializeComponent();
        }

        private void adminEditeUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = user.get_users();
            dgv_edituser.DataSource = dt;
            dgv_edituser.Columns["UserId"].Visible = false;


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim().ToLower();
            string password = txt_pass.Text.Trim().ToLower();
            string email = txt_email.Text.Trim().ToLower();
            int age = Convert.ToInt32(txt_age.Text);
            string address = txt_add.Text.Trim().ToLower();
            string role = comboBox1.SelectedItem?.ToString();




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

            DataTable dt = user.get_users();
            dgv_edituser.DataSource = dt;
            dgv_edituser.Columns["UserId"].Visible = false;


            txt_add.Text = txt_age.Text = txt_email.Text = txt_pass.Text = txt_username.Text = txt_username.Text = "";

        }
        int useid1;
        private void dgv_edituser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            useid1 = int.Parse(dgv_edituser.SelectedRows[0].Cells[0].Value.ToString());


            DataGridViewRow row = dgv_edituser.SelectedRows[0];
            txt_username.Text = Convert.ToString(row.Cells["Username"].Value);
            txt_email.Text = Convert.ToString(row.Cells["Email"].Value);
            txt_age.Text = Convert.ToString(row.Cells["Age"].Value);
            txt_pass.Text = Convert.ToString(row.Cells["password"].Value);
            txt_add.Text = Convert.ToString(row.Cells["Address"].Value);

            comboBox1.Text = Convert.ToString(row.Cells["Role"].Value);




        }

        private void btn_edit_Click(object sender, EventArgs e)
        {


            DataTable dt = user.get_users_by_id(useid1);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found.");
                return;
            }
            string role = comboBox1.SelectedItem?.ToString();
            // string role = dt.Rows[0]["Role"].ToString();
            string pass = dt.Rows[0]["Password"].ToString();
            string username = dt.Rows[0]["Username"].ToString();




            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_age.Text) || string.IsNullOrWhiteSpace(txt_add.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!int.TryParse(txt_age.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }
            //if (user.check_username(username, useid1))
            //{
            //    MessageBox.Show("Username already exists. Please choose another one.");
            //    return;
            //}


            int rows = user.update_user(useid1, txt_username.Text, txt_pass.Text, age, txt_add.Text, role);

            if (rows > 0)
            {
                MessageBox.Show("User updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            DataTable dt1 = user.get_users();
            dgv_edituser.DataSource = dt1;
            dgv_edituser.Columns["UserId"].Visible = false;
            txt_add.Text = txt_age.Text = txt_email.Text = txt_pass.Text = txt_username.Text = txt_username.Text = "";


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int rows = user.delete_user(useid1);
            if (rows > 0)
            {
                MessageBox.Show("User deleted successfully.");
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }

            DataTable dt = user.get_users();
            dgv_edituser.DataSource = dt;
            dgv_edituser.Columns["UserId"].Visible = false;
            txt_add.Text = txt_age.Text = txt_email.Text = txt_pass.Text = txt_username.Text = txt_username.Text = "";


        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            adminedit_products pro = new adminedit_products(_userId);
            pro.Show();

        }

        private void btn_editprofile_Click(object sender, EventArgs e)
        {
            this.Close();
            adminProfile profile = new adminProfile(_userId);
            profile.Show();
        }

        private void btn_editcatigores_Click(object sender, EventArgs e)
        {
            this.Close();
            admineditcategories cat = new admineditcategories(_userId);
            cat.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
