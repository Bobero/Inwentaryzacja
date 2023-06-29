namespace Inwentaryzacja
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            lblLogin = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtPermissions = new TextBox();
            lblPermissions = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(131, 14);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(233, 23);
            txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(14, 17);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 44);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(14, 47);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPermissions
            // 
            txtPermissions.Location = new Point(131, 74);
            txtPermissions.Margin = new Padding(4, 3, 4, 3);
            txtPermissions.Name = "txtPermissions";
            txtPermissions.Size = new Size(233, 23);
            txtPermissions.TabIndex = 4;
            // 
            // lblPermissions
            // 
            lblPermissions.AutoSize = true;
            lblPermissions.Location = new Point(14, 77);
            lblPermissions.Margin = new Padding(4, 0, 4, 0);
            lblPermissions.Name = "lblPermissions";
            lblPermissions.Size = new Size(73, 15);
            lblPermissions.TabIndex = 5;
            lblPermissions.Text = "Permissions:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(182, 121);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(276, 121);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(42, 111);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(83, 19);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "checkBox1";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 162);
            Controls.Add(chkShowPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPermissions);
            Controls.Add(txtPermissions);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox chkShowPassword;
    }
}
