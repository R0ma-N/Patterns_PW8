﻿namespace PW8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(141, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(142, 20);
            this.TextBox.TabIndex = 0;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 355);
            this.ListBox.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(141, 38);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(142, 36);
            this.Button.TabIndex = 2;
            this.Button.Text = "button1";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 388);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button Button;
    }
}

