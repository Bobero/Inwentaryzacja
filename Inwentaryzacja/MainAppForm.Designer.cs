namespace Inwentaryzacja
{
    partial class MainAppForm
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
            AddCommodity = new Button();
            UsersManage = new Button();
            SuspendLayout();
            // 
            // AddCommodity
            // 
            AddCommodity.Location = new Point(12, 69);
            AddCommodity.Name = "AddCommodity";
            AddCommodity.Size = new Size(166, 48);
            AddCommodity.TabIndex = 0;
            AddCommodity.Text = "Dodaj Towar";
            AddCommodity.UseVisualStyleBackColor = true;
            // 
            // UsersManage
            // 
            UsersManage.Location = new Point(211, 69);
            UsersManage.Name = "UsersManage";
            UsersManage.Size = new Size(166, 48);
            UsersManage.TabIndex = 1;
            UsersManage.Text = "Zarządzaj Użytkownikami";
            UsersManage.UseVisualStyleBackColor = true;
            // 
            // MainAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UsersManage);
            Controls.Add(AddCommodity);
            Name = "MainAppForm";
            Text = "MainAppForm";
            Load += MainAppForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddCommodity;
        private Button UsersManage;
    }
}