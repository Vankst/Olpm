namespace Olmp
{
    partial class SignUp
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
            this.panellLogo = new System.Windows.Forms.Panel();
            this.tb_passwordr = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_signin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.tb_passwordr);
            this.panellLogo.Controls.Add(this.lbl_error);
            this.panellLogo.Controls.Add(this.btn_reg);
            this.panellLogo.Controls.Add(this.tb_password);
            this.panellLogo.Controls.Add(this.tb_email);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(220, 0);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(580, 450);
            this.panellLogo.TabIndex = 3;
            // 
            // tb_passwordr
            // 
            this.tb_passwordr.Location = new System.Drawing.Point(48, 229);
            this.tb_passwordr.Multiline = true;
            this.tb_passwordr.Name = "tb_passwordr";
            this.tb_passwordr.PasswordChar = '*';
            this.tb_passwordr.Size = new System.Drawing.Size(477, 42);
            this.tb_passwordr.TabIndex = 7;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(251, 302);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(51, 20);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "label1";
            this.lbl_error.Visible = false;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(185, 347);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(195, 75);
            this.btn_reg.TabIndex = 5;
            this.btn_reg.Text = "Регистрация";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(48, 158);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(477, 42);
            this.tb_password.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(48, 80);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(477, 42);
            this.tb_email.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_signup);
            this.panelMenu.Controls.Add(this.btn_signin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 2;
            // 
            // btn_signup
            // 
            this.btn_signup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.Location = new System.Drawing.Point(0, 140);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(220, 60);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Регистрация";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // btn_signin
            // 
            this.btn_signin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_signin.FlatAppearance.BorderSize = 0;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_signin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signin.Location = new System.Drawing.Point(0, 80);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(220, 60);
            this.btn_signin.TabIndex = 0;
            this.btn_signin.Text = "Войти";
            this.btn_signin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signin.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.TextBox tb_passwordr;
    }
}