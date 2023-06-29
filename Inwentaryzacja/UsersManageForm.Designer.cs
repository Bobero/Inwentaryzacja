namespace Inwentaryzacja
{
    partial class UsersManageForm
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
            UsersView = new DataGridView();
            AddUserBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersView).BeginInit();
            SuspendLayout();
            // 
            // UsersView
            // 
            UsersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersView.Location = new Point(24, 28);
            UsersView.Name = "UsersView";
            UsersView.RowTemplate.Height = 25;
            UsersView.Size = new Size(745, 361);
            UsersView.TabIndex = 0;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(271, 401);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(257, 37);
            AddUserBtn.TabIndex = 1;
            AddUserBtn.Text = "Dodaj Użytkownika";
            AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // UsersManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddUserBtn);
            Controls.Add(UsersView);
            Name = "UsersManageForm";
            Text = "UsersManageForm";
            Load += UsersManageForm_Load;
            ((System.ComponentModel.ISupportInitialize)UsersView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UsersView;
        private Button AddUserBtn;
    }
}