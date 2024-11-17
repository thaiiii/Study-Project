using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Bai6_2
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

        private void LoadComboBox()
        {
            string link = "http://localhost/baitaprestful/api/donvi";
            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());

            DonVi[] arr = data as DonVi[];
            cboDonVi.DataSource = arr;
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.ValueMember = "MaDonVi";
        }

        private void LoadDataGridView()
        {
            string link = "http://localhost/baitaprestful/api/nhanvien";
            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());

            NhanVien[] arr = data as NhanVien[];
            dataGridView1.DataSource = arr; 


        }

        private void btnTimGioiTinh_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?gioitinh={0}",txtGioiTinh.Text);
            string link = "http://localhost/baitaprestful/api/nhanvien/" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];    
            dataGridView1.DataSource = arr;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?manv={0}&hoten={1}&gioitinh={2}&hsluong={3}&madonvi={4}",
                txtMaNV.Text,
                txtHoTen,
                txtGioiTinh.Text,
                txtHsluong.Text,
                cboDonVi.Text);
            string link = "http://localhost/baitaprestful/api/nhanvien/" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("THem thanh cong");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?manv={0}&hoten={1}&gioitinh={2}&hsluong={3}&madonvi={4}",
                txtMaNV.Text,
                txtHoTen,
                txtGioiTinh.Text,
                txtHsluong.Text,
                cboDonVi.Text);
            string link = "http://localhost/baitaprestful/api/nhanvien/" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";
            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Sua thanh cong");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Sua that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?manv={0}", txtMaNV.Text);
            string link = "http://localhost/baitaprestful/api/nhanvien/" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";
            //Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Xoa thanh cong");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex; // Lấy chỉ số hàng được chọn.

            // Gán giá trị từ DataGridView vào các TextBox.
            txtMaNV.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtHsluong.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();

            // Gán mã danh mục vào SelectedValue thay vì Text.
            int maDonVi = Convert.ToInt32(dataGridView1.Rows[d].Cells[4].Value);
            cboDonVi.SelectedValue = maDonVi; // Tự động hiển thị tên danh mục tương ứng.
        }
    }
}
