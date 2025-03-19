using System.Configuration;
using System.Data;
using Azure.Identity;
using businessLogic;
using prsentation;

namespace myproject
{
    public partial class login : Form
    {
        Users user;
        public login()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.ToString().ToLower();
            string password = txt_pass.Text.ToLower().ToLower();


            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and Password cannot be empty.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            string result = user.Login(email, password);
            if (result.Contains("Error"))
            {
                MessageBox.Show(result);
            }
            string[] parts = result.Split(':');
            if (parts.Length < 3)
            {
                MessageBox.Show("try agin");
                return;
            }

            int id = int.Parse(parts[0]);
            string role = parts[1];
            string Username = parts[2];


            if (result.Contains("Error"))
            {
                MessageBox.Show(result);
            }
            else
            {
                if (role == "Admin")
                {
                    MessageBox.Show($"Welcome {role} {Username}");
                    this.Close();
                    adminProfile ad = new adminProfile(id);
                    ad.Show();
                }
                else
                {
                    MessageBox.Show($"Welcome {Username}");
                    this.Close();
                    userfavproducts us = new userfavproducts(id);
                    us.Show();
                }


            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else {
                txt_pass.UseSystemPasswordChar = true;
            }
                
        }
    }
}
