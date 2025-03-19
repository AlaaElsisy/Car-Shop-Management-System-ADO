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
    public partial class userfavproducts : Form
    {
        Categories categories;
        Favorites favorites;
        Products products;
        private int _userId;
        public userfavproducts(int userId)
        {
            InitializeComponent();
            _userId = userId;
            categories = new Categories(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            favorites = new Favorites(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            products = new Products(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);

        }

        private void userfavproducts_Load(object sender, EventArgs e)
        {
            DataTable categoriess = categories.get_categories();
            com_categories.DataSource = categoriess;
            com_categories.DisplayMember = "CategoryName";
            com_categories.ValueMember = "CategoryId";


            DataTable fav = favorites.get_fave_name(_userId);
            dgv_fav.DataSource = fav;
            dgv_fav.Columns["UserId"].Visible = false;

            DataTable productss = products.get_products();
            dgv_products.DataSource = productss;

        }

        private void btn_userprofile_Click(object sender, EventArgs e)
        {
            this.Close();
            userProfile us = new userProfile(_userId);
            us.Show();

        }


        int proid;
        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            proid = int.Parse(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
            //DataGridViewRow row = dgt_dept.SelectedRows[0];
            //txt_name.Text = Convert.ToString(row.Cells["Dept_Name"].Value);
            //txt_desc.Text = Convert.ToString(row.Cells["Dept_Desc"].Value);
            //txt_loc.Text = Convert.ToString(row.Cells["Dept_Location"].Value);

            DataGridViewRow row = dgv_products.SelectedRows[0];


        }
        private void btn_addfav_Click(object sender, EventArgs e)
        {
            bool x = favorites.ifhasthis(_userId, proid);
            if (x == false)
            {
                int rows = favorites.add_favorite(_userId, proid);

                if (rows > 0)
                {
                    MessageBox.Show("Product added to favorites");
                    DataTable fav = favorites.get_fave_name(_userId);
                    dgv_fav.Columns["UserId"].Visible = false;

                    dgv_fav.DataSource = fav;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Product already in favorites");
            }


        }


        private void com_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //

        }



        private void com_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_categories.SelectedValue != null && int.TryParse(com_categories.SelectedValue.ToString(), out int categoryId))
            {
                DataTable pro = products.get_products_by_category(categoryId);
                dgv_products.DataSource = pro;
            }


        }
        int userId1, favid;

        private void dgv_fav_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_fav.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_fav.SelectedRows[0];

                userId1 = int.Parse(row.Cells["UserId"].Value.ToString());  
                favid = int.Parse(row.Cells["ProductId"].Value.ToString()); 
            }
        }

        //private void btn_removefav_Click(object sender, EventArgs e)
        //{
        //    int rows = favorites.delete_favorite(_userId, favid);


        //    DataTable fav = favorites.get_favorites_by_user(_userId);
        //    dgv_fav.DataSource = fav;
        //    MessageBox.Show("Product deleted from favorites");
        //}
        private void btn_removefav_Click(object sender, EventArgs e)
        {
            if (favid == 0)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            int rows = favorites.delete_favorite(_userId, favid);

            if (rows > 0)
            {
                DataTable fav = favorites.get_fave_name(_userId);
                dgv_fav.Columns["UserId"].Visible = false;

                dgv_fav.DataSource = fav;
                MessageBox.Show("Product deleted from favorites");
            }
            else
            {
                MessageBox.Show("Error: Product not found in favorites.");
            }
        }



    }
}
