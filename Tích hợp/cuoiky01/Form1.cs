using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace cuoiky01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBox();
        }

        public void LoadDataGridView()
        {
            string link = "http://localhost:90/cuoiky/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            SanPham[] arr = data as SanPham[];
            datasp.DataSource = arr;

        }

        public void LoadComboBox()
        {

            string link = "http://localhost:90/cuoiky/api/danhmuc";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            DanhMuc[] arr = data as DanhMuc[];
            cbodm.DataSource = arr;
            cbodm.ValueMember = "MaDanhMuc";
            cbodm.DisplayMember = "TenDanhMuc";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtma.Text, txtten.Text, txtgia.Text, cbodm.SelectedValue);
            string link = "http://localhost:90/cuoiky/api/sanpham/" + postString;
            
            
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Them san pham thanh cong");
            }
            else
            {
                MessageBox.Show("Them san pham that bai");
            }

        }

        private void btntsua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtma.Text, txtten.Text, txtgia.Text, cbodm.SelectedValue);
            string link = "http://localhost:90/cuoiky/api/sanpham/" + putString;
            
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sua san pham thanh cong");
            }
            else
            {
                MessageBox.Show("Sua san pham that bai");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
            string deleteString = string.Format("?ma={0}", txtma.Text);
            string link = "http://localhost:90/cuoiky/api/sanpham/" + deleteString;
            
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xoa san pham thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa san pham that bai");
            }

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string findString = string.Format("?madm={0}", txtmadm.Text);
            string link = "http://localhost:90/cuoiky/api/sanpham/" + findString;

            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            SanPham[] arr = data as SanPham[];
            datasp.DataSource = arr;
        }

        private void datasp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtma.Text = datasp.Rows[d].Cells[0].Value.ToString();
            txtten.Text = datasp.Rows[d].Cells[1].Value.ToString();
            txtgia.Text = datasp.Rows[d].Cells[2].Value.ToString();
            cbodm.Text = datasp.Rows[d].Cells[3].Value.ToString();
        }
    }
}
