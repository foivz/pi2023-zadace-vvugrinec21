namespace WalletWatch
{
    partial class FrmUpdateData
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtDescUpdate = new System.Windows.Forms.TextBox();
            this.txtValueUpdate = new System.Windows.Forms.TextBox();
            this.txtKategory = new System.Windows.Forms.TextBox();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            this.datDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(109, 100);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(66, 13);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "Opis troska: ";
            // 
            // txtDescUpdate
            // 
            this.txtDescUpdate.Location = new System.Drawing.Point(198, 100);
            this.txtDescUpdate.Multiline = true;
            this.txtDescUpdate.Name = "txtDescUpdate";
            this.txtDescUpdate.Size = new System.Drawing.Size(177, 75);
            this.txtDescUpdate.TabIndex = 1;
            // 
            // txtValueUpdate
            // 
            this.txtValueUpdate.Location = new System.Drawing.Point(198, 195);
            this.txtValueUpdate.Name = "txtValueUpdate";
            this.txtValueUpdate.Size = new System.Drawing.Size(177, 20);
            this.txtValueUpdate.TabIndex = 2;
            // 
            // txtKategory
            // 
            this.txtKategory.Location = new System.Drawing.Point(198, 364);
            this.txtKategory.Name = "txtKategory";
            this.txtKategory.Size = new System.Drawing.Size(177, 20);
            this.txtKategory.TabIndex = 5;
            // 
            // cboSelection
            // 
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Location = new System.Drawing.Point(198, 251);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(177, 21);
            this.cboSelection.TabIndex = 6;
            // 
            // datDateUpdate
            // 
            this.datDateUpdate.Location = new System.Drawing.Point(198, 310);
            this.datDateUpdate.Name = "datDateUpdate";
            this.datDateUpdate.Size = new System.Drawing.Size(177, 20);
            this.datDateUpdate.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(433, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Spremi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iznos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vrsta troska:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategorija troska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 20.25F);
            this.label5.Location = new System.Drawing.Point(331, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Izmjena podataka";
            // 
            // FrmUpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.datDateUpdate);
            this.Controls.Add(this.cboSelection);
            this.Controls.Add(this.txtKategory);
            this.Controls.Add(this.txtValueUpdate);
            this.Controls.Add(this.txtDescUpdate);
            this.Controls.Add(this.lblOpis);
            this.Name = "FrmUpdateData";
            this.Text = "FrmUpdateData";
            this.Load += new System.EventHandler(this.FrmUpdateData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtDescUpdate;
        private System.Windows.Forms.TextBox txtValueUpdate;
        private System.Windows.Forms.TextBox txtKategory;
        private System.Windows.Forms.ComboBox cboSelection;
        private System.Windows.Forms.DateTimePicker datDateUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}