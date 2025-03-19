using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myproject;

namespace prsentation
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            login login = new login();
            login.Show();

        }

        private void btn_register1_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();

        }
    }
}
