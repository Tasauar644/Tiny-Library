
namespace Tiny_Library
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteOk = new System.Windows.Forms.Button();
            this.CancelOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Book Stock";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 3;
            // 
            // DeleteOk
            // 
            this.DeleteOk.Location = new System.Drawing.Point(814, 96);
            this.DeleteOk.Name = "DeleteOk";
            this.DeleteOk.Size = new System.Drawing.Size(75, 34);
            this.DeleteOk.TabIndex = 4;
            this.DeleteOk.Text = "OK";
            this.DeleteOk.UseVisualStyleBackColor = true;
            this.DeleteOk.Click += new System.EventHandler(this.DeleteOk_Click);
            // 
            // CancelOK
            // 
            this.CancelOK.Location = new System.Drawing.Point(924, 95);
            this.CancelOK.Name = "CancelOK";
            this.CancelOK.Size = new System.Drawing.Size(75, 35);
            this.CancelOK.TabIndex = 5;
            this.CancelOK.Text = "Cancel";
            this.CancelOK.UseVisualStyleBackColor = true;
            this.CancelOK.Click += new System.EventHandler(this.CancelOK_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.CancelOK);
            this.Controls.Add(this.DeleteOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteOk;
        private System.Windows.Forms.Button CancelOK;
    }
}