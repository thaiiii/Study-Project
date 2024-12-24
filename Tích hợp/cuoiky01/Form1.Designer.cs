namespace cuoiky01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cbodm = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.datasp = new System.Windows.Forms.DataGridView();
            this.txtmadm = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datasp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(137, 37);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(155, 20);
            this.txtma.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(137, 81);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(155, 20);
            this.txtten.TabIndex = 5;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(137, 129);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(155, 20);
            this.txtgia.TabIndex = 6;
            // 
            // cbodm
            // 
            this.cbodm.FormattingEnabled = true;
            this.cbodm.Location = new System.Drawing.Point(137, 178);
            this.cbodm.Name = "cbodm";
            this.cbodm.Size = new System.Drawing.Size(155, 21);
            this.cbodm.TabIndex = 7;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(345, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "button1";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(345, 79);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "button2";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btntsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(345, 127);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "button3";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // datasp
            // 
            this.datasp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.DonGia,
            this.MaDanhMuc});
            this.datasp.Location = new System.Drawing.Point(55, 231);
            this.datasp.Name = "datasp";
            this.datasp.Size = new System.Drawing.Size(452, 150);
            this.datasp.TabIndex = 11;
            this.datasp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasp_CellClick);
            // 
            // txtmadm
            // 
            this.txtmadm.Location = new System.Drawing.Point(137, 406);
            this.txtmadm.Name = "txtmadm";
            this.txtmadm.Size = new System.Drawing.Size(155, 20);
            this.txtmadm.TabIndex = 12;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(345, 403);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 13;
            this.btntim.Text = "button3";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Ma";
            this.Ma.Name = "Ma";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten ";
            this.Ten.Name = "Ten";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Gia";
            this.DonGia.Name = "DonGia";
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Ma DM";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtmadm);
            this.Controls.Add(this.datasp);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbodm);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.ComboBox cbodm;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView datasp;
        private System.Windows.Forms.TextBox txtmadm;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
    }
}

