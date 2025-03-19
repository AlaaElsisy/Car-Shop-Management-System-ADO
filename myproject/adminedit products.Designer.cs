
namespace prsentation
{
    partial class adminedit_products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminedit_products));
            label1 = new Label();
            com_categories = new ComboBox();
            txt_price = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txt_proname = new TextBox();
            label2 = new Label();
            dgv_editproducts = new DataGridView();
            btn_delete = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            btn_editcatigores = new Button();
            btn_editprofile = new Button();
            btn_editusers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_editproducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Tahoma", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(641, 84);
            label1.Name = "label1";
            label1.Size = new Size(554, 71);
            label1.TabIndex = 57;
            label1.Text = "Admin Eidt Products";
            // 
            // com_categories
            // 
            com_categories.BackColor = Color.Gray;
            com_categories.Cursor = Cursors.IBeam;
            com_categories.Font = new Font("Segoe UI", 12F);
            com_categories.ForeColor = Color.White;
            com_categories.FormattingEnabled = true;
            com_categories.Items.AddRange(new object[] { "Admin", "User" });
            com_categories.Location = new Point(340, 583);
            com_categories.Name = "com_categories";
            com_categories.Size = new Size(380, 53);
            com_categories.TabIndex = 90;
            // 
            // txt_price
            // 
            txt_price.BackColor = Color.Gray;
            txt_price.Cursor = Cursors.IBeam;
            txt_price.Font = new Font("Segoe UI", 12F);
            txt_price.ForeColor = Color.White;
            txt_price.Location = new Point(340, 477);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(380, 50);
            txt_price.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Tahoma", 13.875F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(54, 488);
            label9.Name = "label9";
            label9.Size = new Size(97, 45);
            label9.TabIndex = 88;
            label9.Text = "Price";
            label9.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Tahoma", 13.875F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 598);
            label3.Name = "label3";
            label3.Size = new Size(163, 45);
            label3.TabIndex = 87;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // txt_proname
            // 
            txt_proname.BackColor = Color.Gray;
            txt_proname.Cursor = Cursors.IBeam;
            txt_proname.Font = new Font("Segoe UI", 12F);
            txt_proname.ForeColor = Color.White;
            txt_proname.Location = new Point(340, 402);
            txt_proname.Name = "txt_proname";
            txt_proname.Size = new Size(380, 50);
            txt_proname.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Tahoma", 13.875F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 395);
            label2.Name = "label2";
            label2.Size = new Size(249, 45);
            label2.TabIndex = 80;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // dgv_editproducts
            // 
            dgv_editproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_editproducts.Location = new Point(934, 276);
            dgv_editproducts.Name = "dgv_editproducts";
            dgv_editproducts.RowHeadersWidth = 82;
            dgv_editproducts.Size = new Size(724, 526);
            dgv_editproducts.TabIndex = 79;
            dgv_editproducts.RowHeaderMouseDoubleClick += dgv_editproducts_RowHeaderMouseDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DimGray;
            btn_delete.Font = new Font("Tahoma", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(1496, 851);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(121, 46);
            btn_delete.TabIndex = 78;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.DimGray;
            btn_add.Font = new Font("Tahoma", 12F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(1014, 851);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(121, 46);
            btn_add.TabIndex = 77;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.DimGray;
            btn_edit.Font = new Font("Tahoma", 12F);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(1256, 851);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(121, 46);
            btn_edit.TabIndex = 76;
            btn_edit.Text = "Update";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_editcatigores
            // 
            btn_editcatigores.BackColor = Color.DimGray;
            btn_editcatigores.Font = new Font("Tahoma", 12F);
            btn_editcatigores.ForeColor = Color.White;
            btn_editcatigores.Location = new Point(1390, 165);
            btn_editcatigores.Name = "btn_editcatigores";
            btn_editcatigores.Size = new Size(358, 52);
            btn_editcatigores.TabIndex = 74;
            btn_editcatigores.Text = "Edit categories";
            btn_editcatigores.UseVisualStyleBackColor = false;
            btn_editcatigores.Click += btn_editcatigores_Click;
            // 
            // btn_editprofile
            // 
            btn_editprofile.BackColor = Color.DimGray;
            btn_editprofile.Font = new Font("Tahoma", 12F);
            btn_editprofile.ForeColor = Color.White;
            btn_editprofile.Location = new Point(1390, 84);
            btn_editprofile.Name = "btn_editprofile";
            btn_editprofile.Size = new Size(353, 52);
            btn_editprofile.TabIndex = 73;
            btn_editprofile.Text = "Edite Admin profile";
            btn_editprofile.UseVisualStyleBackColor = false;
            btn_editprofile.Click += btn_editprofile_Click;
            // 
            // btn_editusers
            // 
            btn_editusers.BackColor = Color.DimGray;
            btn_editusers.Font = new Font("Tahoma", 12F);
            btn_editusers.ForeColor = Color.White;
            btn_editusers.Location = new Point(1390, 12);
            btn_editusers.Name = "btn_editusers";
            btn_editusers.Size = new Size(358, 52);
            btn_editusers.TabIndex = 72;
            btn_editusers.Text = "Edite users";
            btn_editusers.UseVisualStyleBackColor = false;
            btn_editusers.Click += btn_editusers_Click;
            // 
            // adminedit_products
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1812, 918);
            Controls.Add(com_categories);
            Controls.Add(txt_price);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txt_proname);
            Controls.Add(label2);
            Controls.Add(dgv_editproducts);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(btn_editcatigores);
            Controls.Add(btn_editprofile);
            Controls.Add(btn_editusers);
            Controls.Add(label1);
            Name = "adminedit_products";
            Text = "adminedit_products";
            Load += adminedit_products_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_editproducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label label1;
        private ComboBox com_categories;
        private TextBox txt_price;
        private TextBox txt_age;
        private ComboBox comboBox1;
        private TextBox txt_email;
        private Label label9;
        private Label label3;
        private TextBox txt_proname;
        private TextBox txt_add;
        private Label label5;
        private TextBox txt_pass;
        private TextBox txt_username;
        private Label label6;
        private Label label4;
        private Label label2;
        private DataGridView dgv_editproducts;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_editcatigores;
        private Button btn_editprofile;
        private Button btn_editusers;
    }
}