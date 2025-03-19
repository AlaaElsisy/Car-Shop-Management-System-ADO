namespace prsentation
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            btn_login1 = new Button();
            btn_register1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_login1
            // 
            btn_login1.BackColor = Color.DimGray;
            btn_login1.Font = new Font("Tahoma", 13.875F, FontStyle.Bold);
            btn_login1.ForeColor = Color.White;
            btn_login1.Location = new Point(135, 685);
            btn_login1.Name = "btn_login1";
            btn_login1.Size = new Size(336, 134);
            btn_login1.TabIndex = 1;
            btn_login1.Text = "Login";
            btn_login1.UseVisualStyleBackColor = false;
            btn_login1.Click += btn_login1_Click;
            // 
            // btn_register1
            // 
            btn_register1.BackColor = Color.DimGray;
            btn_register1.Font = new Font("Tahoma", 13.875F, FontStyle.Bold);
            btn_register1.ForeColor = Color.White;
            btn_register1.Location = new Point(1251, 685);
            btn_register1.Name = "btn_register1";
            btn_register1.Size = new Size(336, 134);
            btn_register1.TabIndex = 2;
            btn_register1.Text = "Register";
            btn_register1.UseVisualStyleBackColor = false;
            btn_register1.Click += btn_register1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(315, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 352);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 71);
            label1.Name = "label1";
            label1.Size = new Size(671, 189);
            label1.TabIndex = 0;
            label1.Text = "welcome";
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1750, 993);
            Controls.Add(panel1);
            Controls.Add(btn_register1);
            Controls.Add(btn_login1);
            ForeColor = Color.White;
            Name = "welcome";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_login1;
        private Button btn_register1;
        private Panel panel1;
        private Label label1;
    }
}