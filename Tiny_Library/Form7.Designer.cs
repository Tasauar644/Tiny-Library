
namespace Tiny_Library
{
    partial class Form7
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
            this.BookEntry = new System.Windows.Forms.Button();
            this.BookSearch = new System.Windows.Forms.Button();
            this.BookUpdate = new System.Windows.Forms.Button();
            this.BookDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Mangement";
            // 
            // BookEntry
            // 
            this.BookEntry.Location = new System.Drawing.Point(320, 102);
            this.BookEntry.Name = "BookEntry";
            this.BookEntry.Size = new System.Drawing.Size(100, 36);
            this.BookEntry.TabIndex = 1;
            this.BookEntry.Text = "BookEntry";
            this.BookEntry.UseVisualStyleBackColor = true;
            this.BookEntry.Click += new System.EventHandler(this.BookEntry_Click);
            // 
            // BookSearch
            // 
            this.BookSearch.Location = new System.Drawing.Point(320, 239);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(100, 35);
            this.BookSearch.TabIndex = 2;
            this.BookSearch.Text = "BookSearch";
            this.BookSearch.UseVisualStyleBackColor = true;
            this.BookSearch.Click += new System.EventHandler(this.BookSearch_Click);
            // 
            // BookUpdate
            // 
            this.BookUpdate.Location = new System.Drawing.Point(320, 162);
            this.BookUpdate.Name = "BookUpdate";
            this.BookUpdate.Size = new System.Drawing.Size(100, 35);
            this.BookUpdate.TabIndex = 3;
            this.BookUpdate.Text = "BookUpdate";
            this.BookUpdate.UseVisualStyleBackColor = true;
            this.BookUpdate.Click += new System.EventHandler(this.BookUpdate_Click);
            // 
            // BookDelete
            // 
            this.BookDelete.Location = new System.Drawing.Point(320, 303);
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Size = new System.Drawing.Size(100, 35);
            this.BookDelete.TabIndex = 4;
            this.BookDelete.Text = "BookDelete";
            this.BookDelete.UseVisualStyleBackColor = true;
            this.BookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookDelete);
            this.Controls.Add(this.BookUpdate);
            this.Controls.Add(this.BookSearch);
            this.Controls.Add(this.BookEntry);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BookEntry;
        private System.Windows.Forms.Button BookSearch;
        private System.Windows.Forms.Button BookUpdate;
        private System.Windows.Forms.Button BookDelete;
    }
}