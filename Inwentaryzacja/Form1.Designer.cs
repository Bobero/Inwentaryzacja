﻿namespace Inwentaryzacja
{
    partial class Form1
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
            button_Zaloguj = new Button();
            textBox_Login = new TextBox();
            textBox_Haslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Zaloguj
            // 
            button_Zaloguj.Location = new Point(193, 207);
            button_Zaloguj.Name = "button_Zaloguj";
            button_Zaloguj.Size = new Size(100, 30);
            button_Zaloguj.TabIndex = 0;
            button_Zaloguj.Text = "Zaloguj";
            button_Zaloguj.UseVisualStyleBackColor = true;
            button_Zaloguj.Click += button_Zaloguj_Click;
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(143, 116);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(200, 23);
            textBox_Login.TabIndex = 1;
            // 
            // textBox_Haslo
            // 
            textBox_Haslo.Location = new Point(143, 156);
            textBox_Haslo.Name = "textBox_Haslo";
            textBox_Haslo.PasswordChar = '*';
            textBox_Haslo.Size = new Size(200, 23);
            textBox_Haslo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 159);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "HASŁO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Haslo);
            Controls.Add(textBox_Login);
            Controls.Add(button_Zaloguj);
            Name = "Form1";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Zaloguj;
        private TextBox textBox_Login;
        private TextBox textBox_Haslo;
        private Label label_Login;
        private Label label1;
        private Label label2;
    }
}