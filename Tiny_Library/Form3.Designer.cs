
namespace Tiny_Library
{
    partial class Form3
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
            this.NewBookEntry = new System.Windows.Forms.Label();
            this.NewBookName = new System.Windows.Forms.Label();
            this.BookPublishYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.NewBookOk = new System.Windows.Forms.Button();
            this.NewBooKText = new System.Windows.Forms.TextBox();
            this.Bookpublish = new System.Windows.Forms.TextBox();
            this.Writer = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Catagory = new System.Windows.Forms.TextBox();
            this.EntryDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewBookEntry
            // 
            this.NewBookEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBookEntry.Location = new System.Drawing.Point(434, 9);
            this.NewBookEntry.Name = "NewBookEntry";
            this.NewBookEntry.Size = new System.Drawing.Size(212, 47);
            this.NewBookEntry.TabIndex = 0;
            this.NewBookEntry.Text = "New Book Entry";
            // 
            // NewBookName
            // 
            this.NewBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBookName.Location = new System.Drawing.Point(12, 117);
            this.NewBookName.Name = "NewBookName";
            this.NewBookName.Size = new System.Drawing.Size(110, 33);
            this.NewBookName.TabIndex = 1;
            this.NewBookName.Text = "Book Name:";
            // 
            // BookPublishYear
            // 
            this.BookPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublishYear.Location = new System.Drawing.Point(12, 175);
            this.BookPublishYear.Name = "BookPublishYear";
            this.BookPublishYear.Size = new System.Drawing.Size(154, 36);
            this.BookPublishYear.TabIndex = 2;
            this.BookPublishYear.Text = "BookPublishYear:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Writer Name:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Entry Date:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 43);
            this.label7.TabIndex = 6;
            this.label7.Text = "Catagory Name:";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(570, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 35);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewBookOk
            // 
            this.NewBookOk.Location = new System.Drawing.Point(769, 320);
            this.NewBookOk.Name = "NewBookOk";
            this.NewBookOk.Size = new System.Drawing.Size(114, 35);
            this.NewBookOk.TabIndex = 8;
            this.NewBookOk.Text = "Ok";
            this.NewBookOk.UseVisualStyleBackColor = true;
            this.NewBookOk.Click += new System.EventHandler(this.NewBookOk_Click);
            // 
            // NewBooKText
            // 
            this.NewBooKText.Location = new System.Drawing.Point(176, 117);
            this.NewBooKText.Name = "NewBooKText";
            this.NewBooKText.Size = new System.Drawing.Size(368, 22);
            this.NewBooKText.TabIndex = 9;
            // 
            // Bookpublish
            // 
            this.Bookpublish.Location = new System.Drawing.Point(176, 174);
            this.Bookpublish.Name = "Bookpublish";
            this.Bookpublish.Size = new System.Drawing.Size(368, 22);
            this.Bookpublish.TabIndex = 10;
            // 
            // Writer
            // 
            this.Writer.Location = new System.Drawing.Point(176, 242);
            this.Writer.Name = "Writer";
            this.Writer.Size = new System.Drawing.Size(368, 22);
            this.Writer.TabIndex = 11;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(176, 303);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(133, 22);
            this.Quantity.TabIndex = 12;
            // 
            // Catagory
            // 
            this.Catagory.Location = new System.Drawing.Point(708, 117);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(282, 22);
            this.Catagory.TabIndex = 13;
            // 
            // EntryDate
            // 
            this.EntryDate.Location = new System.Drawing.Point(708, 163);
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.Size = new System.Drawing.Size(282, 22);
            this.EntryDate.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 502);
            this.Controls.Add(this.EntryDate);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Writer);
            this.Controls.Add(this.Bookpublish);
            this.Controls.Add(this.NewBooKText);
            this.Controls.Add(this.NewBookOk);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookPublishYear);
            this.Controls.Add(this.NewBookName);
            this.Controls.Add(this.NewBookEntry);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewBookEntry;
        private System.Windows.Forms.Label NewBookName;
        private System.Windows.Forms.Label BookPublishYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button NewBookOk;
        private System.Windows.Forms.TextBox NewBooKText;
        private System.Windows.Forms.TextBox Bookpublish;
        private System.Windows.Forms.TextBox Writer;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Catagory;
        private System.Windows.Forms.TextBox EntryDate;
    }
}