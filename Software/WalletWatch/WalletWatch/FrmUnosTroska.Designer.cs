﻿namespace WalletWatch
{
    partial class FrmUnosTroska
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtKategorije = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.dtpDatumTroska = new System.Windows.Forms.DateTimePicker();
            this.cboVrste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis troska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta troska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategorija troska:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(208, 32);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(177, 75);
            this.txtOpis.TabIndex = 6;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(208, 137);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(177, 20);
            this.txtIznos.TabIndex = 7;
            // 
            // txtKategorije
            // 
            this.txtKategorije.Enabled = false;
            this.txtKategorije.Location = new System.Drawing.Point(208, 334);
            this.txtKategorije.Name = "txtKategorije";
            this.txtKategorije.ReadOnly = true;
            this.txtKategorije.Size = new System.Drawing.Size(177, 20);
            this.txtKategorije.TabIndex = 9;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(448, 334);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(127, 50);
            this.btnUnos.TabIndex = 10;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // dtpDatumTroska
            // 
            this.dtpDatumTroska.Location = new System.Drawing.Point(208, 203);
            this.dtpDatumTroska.Name = "dtpDatumTroska";
            this.dtpDatumTroska.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumTroska.TabIndex = 11;
            // 
            // cboVrste
            // 
            this.cboVrste.FormattingEnabled = true;
            this.cboVrste.Location = new System.Drawing.Point(208, 266);
            this.cboVrste.Name = "cboVrste";
            this.cboVrste.Size = new System.Drawing.Size(177, 21);
            this.cboVrste.TabIndex = 5;
            this.cboVrste.SelectedIndexChanged += new System.EventHandler(this.cboVrste_SelectedIndexChanged);
            // 
            // FrmUnosTroska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDatumTroska);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtKategorije);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.cboVrste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosTroska";
            this.Text = "FrmUnosTroska";
            this.Load += new System.EventHandler(this.FrmUnosTroska_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtKategorije;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.DateTimePicker dtpDatumTroska;
        private System.Windows.Forms.ComboBox cboVrste;
    }
}