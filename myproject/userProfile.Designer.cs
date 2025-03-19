namespace prsentation
{
    partial class userProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfile));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txt_add = new TextBox();
            label5 = new Label();
            btn_edit = new Button();
            txt_confirmpass = new TextBox();
            txt_newpass = new TextBox();
            txt_oldpass = new TextBox();
            txt_age = new TextBox();
            txt_username = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_add);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(txt_confirmpass);
            panel1.Controls.Add(txt_newpass);
            panel1.Controls.Add(txt_oldpass);
            panel1.Controls.Add(txt_age);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(403, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 949);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(703, 703);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 44);
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(703, 635);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 44);
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(703, 567);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 209);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txt_add
            // 
            txt_add.BackColor = Color.Gray;
            txt_add.Cursor = Cursors.IBeam;
            txt_add.Font = new Font("Segoe UI", 13.875F);
            txt_add.ForeColor = Color.White;
            txt_add.Location = new Point(296, 493);
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(474, 57);
            txt_add.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 13.875F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 493);
            label5.Name = "label5";
            label5.Size = new Size(154, 50);
            label5.TabIndex = 32;
            label5.Text = "Address";
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.DimGray;
            btn_edit.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(215, 819);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(361, 78);
            btn_edit.TabIndex = 30;
            btn_edit.Text = "Update";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.BackColor = Color.Gray;
            txt_confirmpass.Cursor = Cursors.IBeam;
            txt_confirmpass.Font = new Font("Segoe UI", 13.875F);
            txt_confirmpass.ForeColor = Color.White;
            txt_confirmpass.Location = new Point(296, 697);
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.Size = new Size(474, 57);
            txt_confirmpass.TabIndex = 29;
            txt_confirmpass.UseSystemPasswordChar = true;
            // 
            // txt_newpass
            // 
            txt_newpass.BackColor = Color.Gray;
            txt_newpass.Cursor = Cursors.IBeam;
            txt_newpass.Font = new Font("Segoe UI", 13.875F);
            txt_newpass.ForeColor = Color.White;
            txt_newpass.Location = new Point(296, 629);
            txt_newpass.Name = "txt_newpass";
            txt_newpass.Size = new Size(474, 57);
            txt_newpass.TabIndex = 28;
            txt_newpass.UseSystemPasswordChar = true;
            // 
            // txt_oldpass
            // 
            txt_oldpass.BackColor = Color.Gray;
            txt_oldpass.Cursor = Cursors.IBeam;
            txt_oldpass.Font = new Font("Segoe UI", 13.875F);
            txt_oldpass.ForeColor = Color.White;
            txt_oldpass.Location = new Point(296, 561);
            txt_oldpass.Name = "txt_oldpass";
            txt_oldpass.Size = new Size(474, 57);
            txt_oldpass.TabIndex = 27;
            txt_oldpass.UseSystemPasswordChar = true;
            // 
            // txt_age
            // 
            txt_age.BackColor = Color.Gray;
            txt_age.Cursor = Cursors.IBeam;
            txt_age.Font = new Font("Segoe UI", 13.875F);
            txt_age.ForeColor = Color.White;
            txt_age.Location = new Point(296, 425);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(474, 57);
            txt_age.TabIndex = 26;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.Gray;
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Font = new Font("Segoe UI", 13.875F);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(296, 357);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(474, 57);
            txt_username.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 13.875F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 697);
            label8.Name = "label8";
            label8.Size = new Size(232, 50);
            label8.TabIndex = 24;
            label8.Text = "confirmation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 13.875F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 629);
            label7.Name = "label7";
            label7.Size = new Size(262, 50);
            label7.TabIndex = 23;
            label7.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 13.875F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 561);
            label6.Name = "label6";
            label6.Size = new Size(247, 50);
            label6.TabIndex = 22;
            label6.Text = "Old Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 13.875F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 425);
            label4.Name = "label4";
            label4.Size = new Size(87, 50);
            label4.TabIndex = 21;
            label4.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 13.875F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 357);
            label2.Name = "label2";
            label2.Size = new Size(186, 50);
            label2.TabIndex = 20;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1304, 53);
            button1.Name = "button1";
            button1.Size = new Size(245, 66);
            button1.TabIndex = 31;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1616, 1103);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "userProfile";
            Text = "user profile";
            Load += userProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_add;
        private Label label5;
        private Button btn_edit;
        private TextBox txt_confirmpass;
        private TextBox txt_newpass;
        private TextBox txt_oldpass;
        private TextBox txt_age;
        private TextBox txt_username;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}