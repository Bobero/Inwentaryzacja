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
            StockView = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)StockView).BeginInit();
            SuspendLayout();
            // 
            // AddCommodity
            // 
            AddCommodity.Location = new Point(10, 29);
            AddCommodity.Name = "AddCommodity";
            AddCommodity.Size = new Size(166, 48);
            AddCommodity.TabIndex = 0;
            AddCommodity.Text = "Dodaj Towar";
            AddCommodity.UseVisualStyleBackColor = true;
            // 
            // UsersManage
            // 
            UsersManage.Location = new Point(209, 29);
            UsersManage.Name = "UsersManage";
            UsersManage.Size = new Size(166, 48);
            UsersManage.TabIndex = 1;
            UsersManage.Text = "Zarządzaj Użytkownikami";
            UsersManage.UseVisualStyleBackColor = true;
            // 
            // StockView
            // 
            StockView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockView.Location = new Point(10, 177);
            StockView.Name = "StockView";
            StockView.RowTemplate.Height = 25;
            StockView.Size = new Size(1009, 449);
            StockView.TabIndex = 2;
            // 
            // MainAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 638);
            Controls.Add(StockView);
            Controls.Add(UsersManage);
            Controls.Add(AddCommodity);
            Name = "MainAppForm";
            Text = "MainAppForm";
            Load += MainAppForm_Load;
            ((System.ComponentModel.ISupportInitialize)StockView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddCommodity;
        private Button UsersManage;
        private DataGridView StockView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}