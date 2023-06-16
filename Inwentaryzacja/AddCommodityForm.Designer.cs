namespace Inwentaryzacja
{
    partial class AddCommodityForm
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
            NameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            quantityUpDown = new NumericUpDown();
            label3 = new Label();
            descriptionTextBox = new RichTextBox();
            AddButton = new Button();
            CategoryBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            ModelBox = new ComboBox();
            label6 = new Label();
            localBox = new ComboBox();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(124, 24);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(145, 23);
            NameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Nazwa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 197);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Ilość";
            // 
            // quantityUpDown
            // 
            quantityUpDown.Location = new Point(124, 195);
            quantityUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(145, 23);
            quantityUpDown.TabIndex = 4;
            quantityUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 240);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Opis";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(124, 237);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(145, 107);
            descriptionTextBox.TabIndex = 6;
            descriptionTextBox.Text = "";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(194, 368);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 40);
            AddButton.TabIndex = 7;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // CategoryBox
            // 
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Location = new Point(124, 69);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(145, 23);
            CategoryBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 72);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Kategoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 113);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Model";
            // 
            // ModelBox
            // 
            ModelBox.FormattingEnabled = true;
            ModelBox.Location = new Point(124, 110);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(145, 23);
            ModelBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 158);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 13;
            label6.Text = "Lokalizacja";
            // 
            // localBox
            // 
            localBox.FormattingEnabled = true;
            localBox.Location = new Point(124, 150);
            localBox.Name = "localBox";
            localBox.Size = new Size(145, 23);
            localBox.TabIndex = 12;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(110, 368);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(78, 40);
            BackButton.TabIndex = 14;
            BackButton.Text = "Wstecz";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // AddCommodityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(BackButton);
            Controls.Add(label6);
            Controls.Add(localBox);
            Controls.Add(label5);
            Controls.Add(ModelBox);
            Controls.Add(label4);
            Controls.Add(CategoryBox);
            Controls.Add(AddButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(label3);
            Controls.Add(quantityUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Name = "AddCommodityForm";
            Text = "AddCommodityForm";
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private Label label1;
        private Label label2;
        private NumericUpDown quantityUpDown;
        private Label label3;
        private RichTextBox descriptionTextBox;
        private Button AddButton;
        private ComboBox CategoryBox;
        private Label label4;
        private Label label5;
        private ComboBox ModelBox;
        private Label label6;
        private ComboBox localBox;
        private Button BackButton;
    }
}