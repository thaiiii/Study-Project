namespace demo
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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtxuatxuong = new System.Windows.Forms.TextBox();
            this.txtthiphan = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatxuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cong ty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xuat xuong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thi phan";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(73, 16);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(155, 20);
            this.txtnam.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(73, 70);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(155, 20);
            this.txtten.TabIndex = 5;
            // 
            // txtxuatxuong
            // 
            this.txtxuatxuong.Location = new System.Drawing.Point(366, 16);
            this.txtxuatxuong.Name = "txtxuatxuong";
            this.txtxuatxuong.Size = new System.Drawing.Size(155, 20);
            this.txtxuatxuong.TabIndex = 6;
            // 
            // txtthiphan
            // 
            this.txtthiphan.Location = new System.Drawing.Point(366, 66);
            this.txtthiphan.Name = "txtthiphan";
            this.txtthiphan.Size = new System.Drawing.Size(155, 20);
            this.txtthiphan.TabIndex = 7;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(573, 14);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(573, 63);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(573, 113);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "Tim";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nam,
            this.congty,
            this.xuatxuong,
            this.thiphan});
            this.data.Location = new System.Drawing.Point(21, 157);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(627, 282);
            this.data.TabIndex = 11;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // nam
            // 
            this.nam.DataPropertyName = "nam";
            this.nam.HeaderText = "Nam";
            this.nam.Name = "nam";
            // 
            // congty
            // 
            this.congty.DataPropertyName = "congty";
            this.congty.HeaderText = "Cong ty";
            this.congty.Name = "congty";
            // 
            // xuatxuong
            // 
            this.xuatxuong.DataPropertyName = "xuatxuong";
            this.xuatxuong.HeaderText = "Xuat xuong";
            this.xuatxuong.Name = "xuatxuong";
            // 
            // thiphan
            // 
            this.thiphan.DataPropertyName = "thiphan";
            this.thiphan.HeaderText = "Thi phan";
            this.thiphan.Name = "thiphan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 490);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtthiphan);
            this.Controls.Add(this.txtxuatxuong);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtxuatxuong;
        private System.Windows.Forms.TextBox txtthiphan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn congty;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatxuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiphan;
    }
}

