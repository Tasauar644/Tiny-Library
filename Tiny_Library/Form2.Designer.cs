
namespace Tiny_Library
{
    partial class Form2
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
            this.ManagerName = new System.Windows.Forms.Label();
            this.ManagerPasword = new System.Windows.Forms.Label();
            this.NewManagerBox = new System.Windows.Forms.TextBox();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddManager = new System.Windows.Forms.Button();
            this.NewManagerEntry = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteManager = new System.Windows.Forms.Label();
            this.DeleteManagerText = new System.Windows.Forms.TextBox();
            this.ManagerDelete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerName
            // 
            this.ManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerName.Location = new System.Drawing.Point(6, 41);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(135, 31);
            this.ManagerName.TabIndex = 0;
            this.ManagerName.Text = "ManagerName:";
            // 
            // ManagerPasword
            // 
            this.ManagerPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerPasword.Location = new System.Drawing.Point(34, 81);
            this.ManagerPasword.Name = "ManagerPasword";
            this.ManagerPasword.Size = new System.Drawing.Size(95, 38);
            this.ManagerPasword.TabIndex = 1;
            this.ManagerPasword.Text = "Password:";
            // 
            // NewManagerBox
            // 
            this.NewManagerBox.Location = new System.Drawing.Point(147, 41);
            this.NewManagerBox.Name = "NewManagerBox";
            this.NewManagerBox.Size = new System.Drawing.Size(216, 22);
            this.NewManagerBox.TabIndex = 2;
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(147, 81);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(216, 22);
            this.NewPassBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.AddManager);
            this.groupBox1.Controls.Add(this.ManagerName);
            this.groupBox1.Controls.Add(this.NewPassBox);
            this.groupBox1.Controls.Add(this.ManagerPasword);
            this.groupBox1.Controls.Add(this.NewManagerBox);
            this.groupBox1.Location = new System.Drawing.Point(108, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // AddManager
            // 
            this.AddManager.Location = new System.Drawing.Point(144, 129);
            this.AddManager.Name = "AddManager";
            this.AddManager.Size = new System.Drawing.Size(76, 28);
            this.AddManager.TabIndex = 4;
            this.AddManager.Text = "Add";
            this.AddManager.UseVisualStyleBackColor = true;
            this.AddManager.Click += new System.EventHandler(this.AddManager_Click);
            // 
            // NewManagerEntry
            // 
            this.NewManagerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewManagerEntry.Location = new System.Drawing.Point(192, 451);
            this.NewManagerEntry.Name = "NewManagerEntry";
            this.NewManagerEntry.Size = new System.Drawing.Size(233, 37);
            this.NewManagerEntry.TabIndex = 5;
            this.NewManagerEntry.Text = "New Manager Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.DeleteManager);
            this.groupBox2.Controls.Add(this.DeleteManagerText);
            this.groupBox2.Location = new System.Drawing.Point(600, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(141, 98);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 33);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteManager
            // 
            this.DeleteManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteManager.Location = new System.Drawing.Point(6, 41);
            this.DeleteManager.Name = "DeleteManager";
            this.DeleteManager.Size = new System.Drawing.Size(135, 31);
            this.DeleteManager.TabIndex = 0;
            this.DeleteManager.Text = "ManagerName:";
            // 
            // DeleteManagerText
            // 
            this.DeleteManagerText.Location = new System.Drawing.Point(147, 41);
            this.DeleteManagerText.Name = "DeleteManagerText";
            this.DeleteManagerText.Size = new System.Drawing.Size(216, 22);
            this.DeleteManagerText.TabIndex = 2;
            // 
            // ManagerDelete
            // 
            this.ManagerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerDelete.Location = new System.Drawing.Point(680, 451);
            this.ManagerDelete.Name = "ManagerDelete";
            this.ManagerDelete.Size = new System.Drawing.Size(233, 37);
            this.ManagerDelete.TabIndex = 7;
            this.ManagerDelete.Text = "Manager Delete";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manager List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 389);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 695);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NewManagerEntry);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ManagerName;
        private System.Windows.Forms.Label ManagerPasword;
        private System.Windows.Forms.TextBox NewManagerBox;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NewManagerEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label DeleteManager;
        private System.Windows.Forms.TextBox DeleteManagerText;
        private System.Windows.Forms.Label ManagerDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddManager;
    }
}