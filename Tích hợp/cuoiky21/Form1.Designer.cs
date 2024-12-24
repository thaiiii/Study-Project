namespace cuoiky21
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.cboMaDM = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(82, 49);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(82, 100);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(82, 152);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(236, 49);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(100, 20);
            this.txtMaDM.TabIndex = 3;
            // 
            // cboMaDM
            // 
            this.cboMaDM.FormattingEnabled = true;
            this.cboMaDM.Location = new System.Drawing.Point(236, 99);
            this.cboMaDM.Name = "cboMaDM";
            this.cboMaDM.Size = new System.Drawing.Size(121, 21);
            this.cboMaDM.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(418, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "button1";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(418, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "button2";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(418, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "button3";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(261, 152);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "button4";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.DonGia,
            this.MaDanhMuc});
            this.dataGridView1.Location = new System.Drawing.Point(82, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Don gia";
            this.DonGia.Name = "DonGia";
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Ma danh muc";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMaDM);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.ComboBox cboMaDM;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
    }
}

