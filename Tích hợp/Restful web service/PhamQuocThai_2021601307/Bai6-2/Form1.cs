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
    }
}
