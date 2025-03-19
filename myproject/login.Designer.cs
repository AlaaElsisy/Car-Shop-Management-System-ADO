
namespace myproject
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            txt_pass = new TextBox();
            txt_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_login = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.Gray;
            txt_pass.Cursor = Cursors.IBeam;
            txt_pass.Font = new Font("Tahoma", 16.125F);
            txt_pass.Location = new Point(356, 291);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(506, 59);
            txt_pass.TabIndex = 12;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Gray;
            txt_email.Font = new Font("Tahoma", 16.125F);
            txt_email.Location = new Point(356, 126);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(506, 59);
            txt_email.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.125F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 280);
            label3.Name = "label3";
            label3.Size = new Size(231, 52);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.125F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 115);
            label2.Name = "label2";
            label2.Size = new Size(141, 52);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 97);
            label1.Name = "label1";
            label1.Size = new Size(559, 116);
            label1.TabIndex = 7;
            label1.Text = "Login Now";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DimGray;
            btn_login.Font = new Font("Tahoma", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(323, 853);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(471, 91);
            btn_login.TabIndex = 13;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_email);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(41, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 562);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(787, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 41);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1798, 1048);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Name = "login";
            Text = "Form1";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txt_pass;
        private TextBox txt_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_login;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
    }
}
