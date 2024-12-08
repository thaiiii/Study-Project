using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace kttx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //XmlDocument
        XmlDocument doc = new XmlDocument();
        string path = @"D:\Study Project\Tích hợp\kttx2\dsnhanvien.xml";
        int d; //Số chỉ row dc chon trong datagridview

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            dataGridView1.Rows.Clear();
            doc.Load(path);
            //Tao doi tuong ds chua cac nhanvien
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int index = 0;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows.Add();

            foreach(XmlNode nhanvien in DS)
            {
                XmlNode manv = nhanvien.SelectSingleNode("@manv");
                XmlNode hoten = nhanvien.SelectSingleNode("hoten");
                XmlNode ho = hoten.SelectSingleNode("ho");
                XmlNode ten = hoten.SelectSingleNode("ten");
                XmlNode diachi = nhanvien.SelectSingleNode("diachi");
                XmlNode gioitinh = nhanvien.SelectSingleNode("gioitinh");
                XmlNode trinhdo = nhanvien.SelectSingleNode("trinhdo");

                dataGridView1.Rows[index].Cells[0].Value = manv.InnerText.ToString();
                dataGridView1.Rows[index].Cells[1].Value = ho.InnerText.ToString() + " " + ten.InnerText.ToString();
                dataGridView1.Rows[index].Cells[2].Value = diachi.InnerText.ToString();
                dataGridView1.Rows[index].Cells[3].Value = gioitinh.InnerText.ToString();
                dataGridView1.Rows[index].Cells[4].Value = trinhdo.InnerText.ToString();


                dataGridView1.Rows.Add();
                index++;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //doc tai lieu
            doc.Load(path);
            XmlElement root = doc.DocumentElement;

            //Tao nut nhanvien
            XmlNode nhanvien = doc.CreateElement("nhanvien");
            XmlAttribute manv = doc.CreateAttribute("manv");
            XmlNode hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            XmlNode ten = doc.CreateElement("ten");
            XmlNode diachi = doc.CreateElement("diachi");
            XmlNode gioitinh = doc.CreateElement("gioitinh");
            XmlNode trinhdo = doc.CreateElement("trinhdo");

            manv.InnerText = txtma.Text;
            ho.InnerText = txtho.Text;
            ten.InnerText = txtten.Text;
            diachi.InnerText = txtdiachi.Text;
            gioitinh.InnerText = radnam.Checked ? "Nam" : "Nu";
            trinhdo.InnerText = cbotrinhdo.Text;

            root.AppendChild(nhanvien);
            nhanvien.Attributes.Append(manv);   
            nhanvien.AppendChild(hoten);
            hoten.AppendChild(ho);
            hoten.AppendChild(ten);
            nhanvien.AppendChild(diachi);
            nhanvien.AppendChild(gioitinh);
            nhanvien.AppendChild(trinhdo);
            
            doc.Save(path);
            HienThi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //doc tai lieu
            doc.Load(path);
            XmlElement root = doc.DocumentElement;

            //Tao nut nhanvienmoi va xac dinh nhanviencu
            XmlNode nhanviencu = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtma.Text + "']");
            XmlNode nhanvienmoi = doc.CreateElement("nhanvien");
            XmlAttribute manv = doc.CreateAttribute("manv");
            XmlNode hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            XmlNode ten = doc.CreateElement("ten");
            XmlNode diachi = doc.CreateElement("diachi");
            XmlNode gioitinh = doc.CreateElement("gioitinh");
            XmlNode trinhdo = doc.CreateElement("trinhdo");

            manv.InnerText = txtma.Text;
            ho.InnerText = txtho.Text;
            ten.InnerText = txtten.Text;
            diachi.InnerText = txtdiachi.Text;
            gioitinh.InnerText = radnam.Checked ? "Nam" : "Nu";
            trinhdo.InnerText = cbotrinhdo.Text;

            //root.AppendChild(nhanvienmoi);
            root.ReplaceChild(nhanvienmoi, nhanviencu);
            nhanvienmoi.Attributes.Append(manv);   
            nhanvienmoi.AppendChild(hoten);
            hoten.AppendChild(ho);
            hoten.AppendChild(ten);
            nhanvienmoi.AppendChild(diachi);
            nhanvienmoi.AppendChild(gioitinh);
            nhanvienmoi.AppendChild(trinhdo);

            
            doc.Save(path);
            HienThi();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlElement root = doc.DocumentElement;

            XmlNode nhanvienxoa = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtma.Text + "']");
            root.RemoveChild(nhanvienxoa);
            doc.Save(path);
            HienThi();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            doc.Load(path);
            //Tao doi tuong ds chua cac nhanvien
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int index = 0;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows.Add();

            foreach (XmlNode nhanvien in DS)
            {
                XmlNode manv = nhanvien.SelectSingleNode("@manv");
                if (manv.InnerText == txtma.Text)
                {
                    XmlNode hoten = nhanvien.SelectSingleNode("hoten");
                    XmlNode ho = hoten.SelectSingleNode("ho");
                    XmlNode ten = hoten.SelectSingleNode("ten");
                    XmlNode diachi = nhanvien.SelectSingleNode("diachi");
                    XmlNode gioitinh = nhanvien.SelectSingleNode("gioitinh");
                    XmlNode trinhdo = nhanvien.SelectSingleNode("trinhdo");

                    dataGridView1.Rows[index].Cells[0].Value = manv.InnerText.ToString();
                    dataGridView1.Rows[index].Cells[1].Value = ho.InnerText.ToString() + " " + ten.InnerText.ToString();
                    dataGridView1.Rows[index].Cells[2].Value = diachi.InnerText.ToString();
                    dataGridView1.Rows[index].Cells[3].Value = gioitinh.InnerText.ToString();
                    dataGridView1.Rows[index].Cells[4].Value = trinhdo.InnerText.ToString();
                    dataGridView1.Rows.Add();
                    index++;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtma.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            //txtho.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode nhanvien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtma.Text + "']");
            XmlNode hoten = nhanvien.SelectSingleNode("hoten");
            XmlNode ho = hoten.SelectSingleNode("ho");
            XmlNode ten = hoten.SelectSingleNode("ten");

            txtho.Text = ho.InnerText;
            txtten.Text = ten.InnerText;
            txtdiachi.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            string gioitinh = dataGridView1.Rows[d].Cells[3].Value.ToString();
            if (gioitinh == "Nam")
                radnam.Checked = true;
            else if (gioitinh == "Nu")
                radnu.Checked = true;
            cbotrinhdo.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
        }
    }
}
