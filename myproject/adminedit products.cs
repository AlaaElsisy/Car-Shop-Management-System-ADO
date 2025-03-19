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
    public partial class adminedit_products : Form
    {
        Categories categories;
        // Favorites favorites;
        Products products;
        private int _userId;
        Users user;
        public adminedit_products(int userId)
        {
            _userId = userId;
            InitializeComponent();
            categories = new Categories(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            // favorites = new Favorites(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            products = new Products(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
        }
        private void ClearFields()
        {
            txt_proname.Text = "";
            txt_price.Text = "";
            com_categories.SelectedIndex = -1;
        }

        private void adminedit_products_Load(object sender, EventArgs e)
        {
            DataTable categoriess = categories.get_categories();
            com_categories.DataSource = categoriess;
            com_categories.DisplayMember = "CategoryName";
            com_categories.ValueMember = "CategoryId";

            DataTable productss = products.get_products();
            dgv_editproducts.DataSource = productss;
            dgv_editproducts.Columns["ProductId"].Visible = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string prodname = txt_proname.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(prodname))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }


            if (com_categories.SelectedValue == null)
            {
                MessageBox.Show("Select a category.");
                return;
            }

            int categoryId = Convert.ToInt32(com_categories.SelectedValue);

            if (products.check_product_name(prodname, categoryId))
            {
                MessageBox.Show("Product name already exists.");
                return;
            }


            int rows = products.add_product(prodname, price, categoryId);
            if (rows > 0)
            {
                MessageBox.Show("Product added successfully.");

                dgv_editproducts.DataSource = products.get_products();
                dgv_editproducts.Columns["ProductId"].Visible = false;
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }

        }
        int proid;
        private void dgv_editproducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            proid = int.Parse(dgv_editproducts.SelectedRows[0].Cells[0].Value.ToString());


            DataGridViewRow row = dgv_editproducts.SelectedRows[0];

            txt_proname.Text = Convert.ToString(row.Cells["ProductName"].Value);

            txt_price.Text = Convert.ToString(row.Cells["Price"].Value);


            if (row.Cells["CategoryId"].Value != DBNull.Value)
            {
                com_categories.SelectedValue = Convert.ToInt32(row.Cells["CategoryId"].Value);
            }
            else
            {
                com_categories.SelectedValue = 1;
            }

            // comboBox1.Text = Convert.ToString(row.Cells["Role"].Value);

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_editproducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            int productId = Convert.ToInt32(dgv_editproducts.SelectedRows[0].Cells["ProductId"].Value);
            string prodname = txt_proname.Text.Trim().ToLower();
            //double price;
            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }



            int categoryId = Convert.ToInt32(com_categories.SelectedValue);


            int rows = products.update_product(productId, prodname, price, categoryId);
            if (rows > 0)
            {
                MessageBox.Show("Product updated successfully.");
                dgv_editproducts.DataSource = products.get_products();
                dgv_editproducts.Columns["ProductId"].Visible = false;

                ClearFields();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_editproducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(dgv_editproducts.SelectedRows[0].Cells["ProductId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int rows = products.delete_product(productId);
                if (rows > 0)
                {
                    MessageBox.Show("Product deleted successfully.");
                    dgv_editproducts.DataSource = products.get_products();
                    dgv_editproducts.Columns["ProductId"].Visible = false;

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Deletion failed.");
                }
            }
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

        private void btn_editusers_Click(object sender, EventArgs e)
        {
            this.Close();
            adminEditeUsers user = new adminEditeUsers(_userId);
            user.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
