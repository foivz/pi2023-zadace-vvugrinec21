namespace WalletWatch
{
    partial class FrmTroskovi
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
            this.dgvTroskovi = new System.Windows.Forms.DataGridView();
            this.btnUnesiNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroskovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTroskovi
            // 
            this.dgvTroskovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTroskovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTroskovi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTroskovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTroskovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTroskovi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTroskovi.Location = new System.Drawing.Point(21, 24);
            this.dgvTroskovi.Name = "dgvTroskovi";
            this.dgvTroskovi.Size = new System.Drawing.Size(793, 381);
            this.dgvTroskovi.TabIndex = 0;
            // 
            // btnUnesiNovi
            // 
            this.btnUnesiNovi.Location = new System.Drawing.Point(436, 425);
            this.btnUnesiNovi.Name = "btnUnesiNovi";
            this.btnUnesiNovi.Size = new System.Drawing.Size(122, 42);
            this.btnUnesiNovi.TabIndex = 1;
            this.btnUnesiNovi.Text = "Unesi novi trosak";
            this.btnUnesiNovi.UseVisualStyleBackColor = true;
            this.btnUnesiNovi.Click += new System.EventHandler(this.btnUnesiNovi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(564, 425);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(122, 42);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi trosak";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite pojam po kojem zelite pretrazivati podatke:";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(21, 437);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(237, 20);
            this.txtPretrazivanje.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(274, 435);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(692, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Promijeni podatke";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmTroskovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(941, 514);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUnesiNovi);
            this.Controls.Add(this.dgvTroskovi);
            this.Name = "FrmTroskovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTroskovi";
            this.Load += new System.EventHandler(this.FrmTroskovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroskovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTroskovi;
        private System.Windows.Forms.Button btnUnesiNovi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnUpdate;
    }
}