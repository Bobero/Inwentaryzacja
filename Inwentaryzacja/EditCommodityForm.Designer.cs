namespace Inwentaryzacja
{
    partial class EditCommodityForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.UIDTextBox = new System.Windows.Forms.TextBox();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.LokalizacjaTextBox = new System.Windows.Forms.TextBox();
            this.KategoriaTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.DataDodaniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UIDTextBox
            // 
            this.UIDTextBox.Location = new System.Drawing.Point(128, 25);
            this.UIDTextBox.Name = "UIDTextBox";
            this.UIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.UIDTextBox.TabIndex = 0;
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(128, 59);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(200, 20);
            this.NazwaTextBox.TabIndex = 1;
            // 
            // LokalizacjaTextBox
            // 
            this.LokalizacjaTextBox.Location = new System.Drawing.Point(128, 93);
            this.LokalizacjaTextBox.Name = "LokalizacjaTextBox";
            this.LokalizacjaTextBox.Size = new System.Drawing.Size(200, 20);
            this.LokalizacjaTextBox.TabIndex = 2;
            // 
            // KategoriaTextBox
            // 
            this.KategoriaTextBox.Location = new System.Drawing.Point(128, 127);
            this.KategoriaTextBox.Name = "KategoriaTextBox";
            this.KategoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.KategoriaTextBox.TabIndex = 3;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(128, 161);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(200, 20);
            this.ModelTextBox.TabIndex = 4;
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(128, 195);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(200, 100);
            this.OpisTextBox.TabIndex = 5;
            // 
            // DataDodaniaDateTimePicker
            // 
            this.DataDodaniaDateTimePicker.Location = new System.Drawing.Point(128, 305);
            this.DataDodaniaDateTimePicker.Name = "DataDodaniaDateTimePicker";
            this.DataDodaniaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DataDodaniaDateTimePicker.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(128, 349);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(253, 349);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "UID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lokalizacja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data dodania:";
            // 
            // EditCommodityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 396);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataDodaniaDateTimePicker);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.KategoriaTextBox);
            this.Controls.Add(this.LokalizacjaTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.UIDTextBox);
            this.Name = "EditCommodityForm";
            this.Text = "Edytuj towar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UIDTextBox;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox LokalizacjaTextBox;
        private System.Windows.Forms.TextBox KategoriaTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.DateTimePicker DataDodaniaDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
