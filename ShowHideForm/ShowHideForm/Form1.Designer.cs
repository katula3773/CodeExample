﻿namespace ShowHideForm
{
    partial class Form1
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
            this.btnCallForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallForm
            // 
            this.btnCallForm.Location = new System.Drawing.Point(191, 73);
            this.btnCallForm.Name = "btnCallForm";
            this.btnCallForm.Size = new System.Drawing.Size(75, 23);
            this.btnCallForm.TabIndex = 0;
            this.btnCallForm.Text = "Call Form 2";
            this.btnCallForm.UseVisualStyleBackColor = true;
            this.btnCallForm.Click += new System.EventHandler(this.btnCallForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 191);
            this.Controls.Add(this.btnCallForm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallForm;
    }
}
