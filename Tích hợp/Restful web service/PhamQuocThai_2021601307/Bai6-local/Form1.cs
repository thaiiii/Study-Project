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
using System.IO;
using System.Runtime.Serialization.Json;

namespace Bai6_local
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
            //Link goi API lay toan bo san pham chua cai web api len iis
            string link = "http://localhost/hocrestful/api/sanpham";
            //tao mot yeu cau gui toi mot website su dung lop HttpWebRequest
            HttpWebRequest request = WebRequest.CreateHttp(link);
            //
            WebResponse response = request.GetResponse();
            //
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            //
            object data = js.ReadObject(response.GetResponseStream());

            //
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr;


        }

        public void LoadComboBox()
        {
            //
            string link = "http://localhost/hocrestful/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] arr1 = data as DanhMuc[];
            //DanhMuc[] arr2 = data as DanhMuc[];
            //arr2[0] = new DanhMuc(3, "siuu");
            //arr2[1] = new DanhMuc(3, "sadsa");
            cboDanhMuc.DataSource = arr1;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSP.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            cboDanhMuc.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}",
                txtMaSP.Text,
                txtTenSP.Text,
                txtDonGia.Text,
                cboDanhMuc.SelectedValue);
            //
            string link = "http://localhost/hocrestful/api/sanpham" + postString;
            //
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            
            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            //Lay du lieu tra ve tu luong du lieu
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}",
                txtMaSP.Text,
                txtTenSP.Text,
                txtDonGia.Text,
                cboDanhMuc.SelectedValue);
            //
            string link = "http://localhost/hocrestful/api/sanpham" + putString;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string deleteString = string.Format("?ma={0}", masp);
            string link = "http://localhost/hocrestful/api/sanpham" + deleteString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {

                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string link = "http://localhost/hocrestful/api/sanpham?madm=" + madm;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr; 

        }
    }
}
