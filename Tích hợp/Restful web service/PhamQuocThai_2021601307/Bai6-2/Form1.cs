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
            //Lay danh sach tu NhanVien
            string linkNhanVien = "http://localhost/baitaprestful/api/nhanvien";
            HttpWebRequest requestNhanVien = WebRequest.CreateHttp(linkNhanVien);

            WebResponse responseNhanVien = requestNhanVien.GetResponse();
            DataContractJsonSerializer jsNhanVien = new DataContractJsonSerializer(typeof(NhanVien[]));
            object dataNhanVien = jsNhanVien.ReadObject(responseNhanVien.GetResponseStream());
            NhanVien[] arrNhanVien = dataNhanVien as NhanVien[];


            //Lay danh sach tu DonVi
            string linkDonVi = "http://localhost/baitaprestful/api/donvi";
            HttpWebRequest requestDonVi = WebRequest.CreateHttp(linkDonVi);

            WebResponse responseDonVi = requestDonVi.GetResponse();
            DataContractJsonSerializer jsDonVi = new DataContractJsonSerializer(typeof(DonVi[]));
            object dataDonVi = jsDonVi.ReadObject(responseDonVi.GetResponseStream());
            DonVi[] arrDonVi = dataDonVi as DonVi[];

            //Anh xa ten don vi vao nhan vien
            var result = arrNhanVien.Select(nv => new
            {
                MaNV = nv.MaNV,
                HoTen = nv.HoTen,
                GioiTinh = nv.GioiTinh,
                Hsluong = nv.Hsluong,
                MaDonVi = nv.MaDonVi,
                TenDonVi = arrDonVi.FirstOrDefault(dv => dv.MaDonVi == nv.MaDonVi)?.TenDonVi ?? "Khong xac dinh"
            }).ToList();

            dataGridView1.DataSource = result;


        }

        private void btnTimGioiTinh_Click(object sender, EventArgs e)
        {
            //Lay danh sach tu NhanVien
            string postLink = string.Format("?GioiTinh={0}", txtGioiTinh.Text);
            string linkNhanVien = "http://localhost/baitaprestful/api/nhanvien" + postLink;
            HttpWebRequest requestNhanVien = WebRequest.CreateHttp(linkNhanVien);
            WebResponse responseNhanVien = requestNhanVien.GetResponse();
            
            DataContractJsonSerializer jsNhanVien = new DataContractJsonSerializer(typeof(NhanVien[]));
            object dataNhanVien = jsNhanVien.ReadObject(responseNhanVien.GetResponseStream());
            NhanVien[] arrNhanVien = dataNhanVien as NhanVien[];


            //Lay danh sach tu DonVi
            string linkDonVi = "http://localhost/baitaprestful/api/donvi";
            HttpWebRequest requestDonVi = WebRequest.CreateHttp(linkDonVi);
            WebResponse responseDonVi = requestDonVi.GetResponse();

            DataContractJsonSerializer jsDonVi = new DataContractJsonSerializer(typeof(DonVi[]));
            object dataDonVi = jsDonVi.ReadObject(responseDonVi.GetResponseStream());
            DonVi[] arrDonVi = dataDonVi as DonVi[];

            var result = arrNhanVien.Select(nv => new
            {
                MaNV = nv.MaNV,
                HoTen = nv.HoTen,
                GioiTinh = nv.GioiTinh,
                Hsluong = nv.Hsluong,
                MaDonVi = nv.MaDonVi,
                TenDonVi = arrDonVi.FirstOrDefault(dv => dv.MaDonVi == nv.MaDonVi)?.TenDonVi ?? "Khong xac dinh"
            }).ToList();


            dataGridView1.DataSource = result;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?MaNV={0}&HoTen={1}&GioiTinh={2}&Hsluong={3}&MaDonVi={4}",
                txtMaNV.Text,
                txtHoTen.Text,
                txtGioiTinh.Text,
                txtHsluong.Text,
                cboDonVi.SelectedValue);
            string link = "http://localhost/baitaprestful/api/nhanvien" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer (typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Them thanh cong");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?MaNV={0}&HoTen={1}&GioiTinh={2}&Hsluong={3}&MaDonVi={4}",
                txtMaNV.Text,
                txtHoTen.Text,
                txtGioiTinh.Text,
                txtHsluong.Text,
                cboDonVi.SelectedValue);
            string link = "http://localhost/baitaprestful/api/nhanvien" + postLink;

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
            string postLink = string.Format("?MaNV={0}", txtMaNV.Text);
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

            cboDonVi.SelectedValue = Convert.ToInt32(dataGridView1.Rows[d].Cells[4].Value); 
            // Tự động hiển thị tên danh mục tương ứng.
        }

        
    }
}
