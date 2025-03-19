
namespace prsentation
{
    partial class admineditcategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admineditcategories));
            label1 = new Label();
            dgv_editcat = new DataGridView();
            btn_editproducts = new Button();
            btn_editprofile = new Button();
            btn_editusers = new Button();
            panel1 = new Panel();
            txt_catname = new TextBox();
            label2 = new Label();
            btn_delete = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_editcat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(714, 50);
            label1.Name = "label1";
            label1.Size = new Size(502, 77);
            label1.TabIndex = 57;
            label1.Text = " Eidt Categoris";
            // 
            // dgv_editcat
            // 
            dgv_editcat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_editcat.Location = new Point(998, 322);
            dgv_editcat.Name = "dgv_editcat";
            dgv_editcat.RowHeadersWidth = 82;
            dgv_editcat.Size = new Size(451, 475);
            dgv_editcat.TabIndex = 98;
            dgv_editcat.RowHeaderMouseDoubleClick += dgv_editcat_RowHeaderMouseDoubleClick;
            // 
            // btn_editproducts
            // 
            btn_editproducts.BackColor = Color.DimGray;
            btn_editproducts.Font = new Font("Tahoma", 10.875F);
            btn_editproducts.ForeColor = Color.White;
            btn_editproducts.Location = new Point(1451, 182);
            btn_editproducts.Name = "btn_editproducts";
            btn_editproducts.Size = new Size(258, 52);
            btn_editproducts.TabIndex = 94;
            btn_editproducts.Text = "Edit Products";
            btn_editproducts.UseVisualStyleBackColor = false;
            btn_editproducts.Click += btn_editproducts_Click;
            // 
            // btn_editprofile
            // 
            btn_editprofile.BackColor = Color.DimGray;
            btn_editprofile.Font = new Font("Tahoma", 10.875F);
            btn_editprofile.ForeColor = Color.White;
            btn_editprofile.Location = new Point(1451, 101);
            btn_editprofile.Name = "btn_editprofile";
            btn_editprofile.Size = new Size(253, 52);
            btn_editprofile.TabIndex = 93;
            btn_editprofile.Text = "Edit Admin profile";
            btn_editprofile.UseVisualStyleBackColor = false;
            btn_editprofile.Click += btn_editprofile_Click;
            // 
            // btn_editusers
            // 
            btn_editusers.BackColor = Color.DimGray;
            btn_editusers.Font = new Font("Tahoma", 10.875F);
            btn_editusers.ForeColor = Color.White;
            btn_editusers.Location = new Point(1451, 29);
            btn_editusers.Name = "btn_editusers";
            btn_editusers.Size = new Size(258, 52);
            btn_editusers.TabIndex = 92;
            btn_editusers.Text = "Edit users";
            btn_editusers.UseVisualStyleBackColor = false;
            btn_editusers.Click += btn_editusers_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(txt_catname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_edit);
            panel1.Location = new Point(58, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 782);
            panel1.TabIndex = 99;
            // 
            // txt_catname
            // 
            txt_catname.BackColor = Color.DimGray;
            txt_catname.Cursor = Cursors.IBeam;
            txt_catname.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_catname.Location = new Point(61, 334);
            txt_catname.Name = "txt_catname";
            txt_catname.Size = new Size(380, 46);
            txt_catname.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 244);
            label2.Name = "label2";
            label2.Size = new Size(306, 45);
            label2.TabIndex = 104;
            label2.Text = "Category Name";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DimGray;
            btn_delete.Font = new Font("Tahoma", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(473, 658);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 61);
            btn_delete.TabIndex = 103;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.DimGray;
            btn_add.Font = new Font("Tahoma", 12F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(22, 658);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(186, 61);
            btn_add.TabIndex = 102;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.DimGray;
            btn_edit.Font = new Font("Tahoma", 12F);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(255, 658);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(186, 61);
            btn_edit.TabIndex = 101;
            btn_edit.Text = "Update";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // admineditcategories
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1759, 975);
            Controls.Add(panel1);
            Controls.Add(dgv_editcat);
            Controls.Add(btn_editproducts);
            Controls.Add(btn_editprofile);
            Controls.Add(btn_editusers);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "admineditcategories";
            Text = "admineditcategories";
            Load += admineditcategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_editcat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label1;
        private ComboBox com_categories;
        private TextBox txt_price;
        private Label label9;
        private Label label3;
        private DataGridView dgv_editcat;
        private Button btn_editproducts;
        private Button btn_editprofile;
        private Button btn_editusers;
        private Panel panel1;
        private TextBox txt_catname;
        private Label label2;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_edit;
    }
}