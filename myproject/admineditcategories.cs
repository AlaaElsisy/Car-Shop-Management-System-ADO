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
    public partial class admineditcategories : Form
    {

        private int _userId;
        Users user;
        Categories categories;
        // Favorites favorites;
        // Products products;

        public admineditcategories(int userId)
        {
            categories = new Categories(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            // favorites = new Favorites(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            //products = new Products(ConfigurationManager.ConnectionStrings["eco"].ConnectionString);
            _userId = userId;
            InitializeComponent();
        }

        private void admineditcategories_Load(object sender, EventArgs e)
        {
            DataTable cat = categories.get_categories();
            dgv_editcat.DataSource = cat;
            dgv_editcat.Columns["CategoryId"].Visible = false;

        }
        private void ClearFields()
        {
            txt_catname.Text = "";

        }

        int categoryId;
        private void dgv_editcat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryId = int.Parse(dgv_editcat.SelectedRows[0].Cells[0].Value.ToString());


            DataGridViewRow row = dgv_editcat.SelectedRows[0];

            txt_catname.Text = Convert.ToString(row.Cells["CategoryName"].Value);


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string categoryName = txt_catname.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name is required.");
                return;
            }

            if (categories.check_category_name(categoryName))
            {
                MessageBox.Show("Category already exists.");
                return;
            }

            int rows = categories.add_category(categoryName);

            if (rows > 0)
            {
                MessageBox.Show("Category added successfully.");
                ClearFields();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_editcat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a category to edit.");
                return;
            }

            categoryId = Convert.ToInt32(dgv_editcat.SelectedRows[0].Cells["CategoryId"].Value);
            string newCategoryName = txt_catname.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategoryName))
            {
                MessageBox.Show("Category name is required.");
                return;
            }

            //if (categories.check_category_name(newCategoryName))
            //{
            //    MessageBox.Show("Category name already exists.");
            //    return;
            //}

            int rows = categories.update_category(categoryId, newCategoryName);

            if (rows > 0)
            {
                MessageBox.Show("Category updated successfully.");
                ClearFields();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_editcat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a category to delete.");
                return;
            }

            categoryId = Convert.ToInt32(dgv_editcat.SelectedRows[0].Cells["CategoryId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int rows = categories.delete_category(categoryId);

                if (rows > 0)
                {
                    MessageBox.Show("Category deleted successfully.");
                    ClearFields();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Deletion failed.");
                }
            }
        }

        // Helper Methods
        private void LoadCategories()
        {
            DataTable dt = categories.get_categories();
            dgv_editcat.DataSource = dt;
            dgv_editcat.Columns["CategoryId"].Visible = false;
        }

        private void btn_editusers_Click(object sender, EventArgs e)
        {
            this.Close();
            adminEditeUsers user = new adminEditeUsers(_userId);
            user.Show();

        }

        private void btn_editprofile_Click(object sender, EventArgs e)
        {
            this.Close();
            adminProfile profile = new adminProfile(_userId);
            profile.Show();
        }

        private void btn_editproducts_Click(object sender, EventArgs e)
        {
            this.Close();
            adminedit_products pro = new adminedit_products(_userId);
            pro.Show();
        }

        private void txt_catname_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

    }
}
