namespace prsentation
{
    partial class userfavproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userfavproducts));
            btn_userprofile = new Button();
            btn_removefav = new Button();
            btn_addfav = new Button();
            dgv_fav = new DataGridView();
            label3 = new Label();
            com_categories = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgv_products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_fav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            SuspendLayout();
            // 
            // btn_userprofile
            // 
            btn_userprofile.BackColor = Color.DimGray;
            btn_userprofile.Font = new Font("Tahoma", 12F);
            btn_userprofile.ForeColor = Color.White;
            btn_userprofile.Location = new Point(1570, 21);
            btn_userprofile.Name = "btn_userprofile";
            btn_userprofile.Size = new Size(219, 59);
            btn_userprofile.TabIndex = 17;
            btn_userprofile.Text = "User Profile";
            btn_userprofile.UseVisualStyleBackColor = false;
            btn_userprofile.Click += btn_userprofile_Click;
            // 
            // btn_removefav
            // 
            btn_removefav.BackColor = Color.DimGray;
            btn_removefav.Font = new Font("Tahoma", 12F);
            btn_removefav.ForeColor = Color.White;
            btn_removefav.Location = new Point(1110, 762);
            btn_removefav.Name = "btn_removefav";
            btn_removefav.Size = new Size(322, 72);
            btn_removefav.TabIndex = 12;
            btn_removefav.Text = "Remove from Fav";
            btn_removefav.UseVisualStyleBackColor = false;
            btn_removefav.Click += btn_removefav_Click;
            // 
            // btn_addfav
            // 
            btn_addfav.BackColor = Color.DimGray;
            btn_addfav.Font = new Font("Tahoma", 12F);
            btn_addfav.ForeColor = Color.White;
            btn_addfav.Location = new Point(493, 762);
            btn_addfav.Name = "btn_addfav";
            btn_addfav.Size = new Size(242, 72);
            btn_addfav.TabIndex = 11;
            btn_addfav.Text = "Add to Fav";
            btn_addfav.UseVisualStyleBackColor = false;
            btn_addfav.Click += btn_addfav_Click;
            // 
            // dgv_fav
            // 
            dgv_fav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_fav.Location = new Point(979, 312);
            dgv_fav.Name = "dgv_fav";
            dgv_fav.RowHeadersWidth = 82;
            dgv_fav.Size = new Size(480, 300);
            dgv_fav.TabIndex = 21;
            dgv_fav.RowHeaderMouseDoubleClick += dgv_fav_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1200, 263);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 23;
            label3.Text = "Favorites";
            // 
            // com_categories
            // 
            com_categories.BackColor = Color.DimGray;
            com_categories.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            com_categories.ForeColor = Color.White;
            com_categories.FormattingEnabled = true;
            com_categories.Location = new Point(188, 142);
            com_categories.Name = "com_categories";
            com_categories.Size = new Size(336, 47);
            com_categories.TabIndex = 18;
            com_categories.SelectedIndexChanged += com_categories_SelectedValueChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(559, 263);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 22;
            label2.Text = "Products";
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(188, 86);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 19;
            label1.Text = "Categories";
            // 
            // dgv_products
            // 
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(405, 312);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 82;
            dgv_products.Size = new Size(480, 300);
            dgv_products.TabIndex = 20;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // userfavproducts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1801, 997);
            Controls.Add(dgv_fav);
            Controls.Add(label3);
            Controls.Add(com_categories);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_products);
            Controls.Add(btn_userprofile);
            Controls.Add(btn_addfav);
            Controls.Add(btn_removefav);
            DoubleBuffered = true;
            Name = "userfavproducts";
            Text = "userfavproducts";
            Load += userfavproducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_fav).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_userprofile;
        private Button btn_removefav;
        private DataGridView dgv_fav;
        private Label label3;
        private ComboBox com_categories;
        private Label label2;
        private Label label1;
        private DataGridView dgv_products;
        private Button btn_addfav;
    }
}