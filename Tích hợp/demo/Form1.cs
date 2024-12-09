using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        int index;
        string path = @"D:\Study Project\Tích hợp\demo\SanXuatDienThoai.xml";

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNodeList DSthoigian = root.SelectNodes("/sanxuatdienthoai/thoigian");
            int i = 0;
            data.Rows.Clear();
            data.Rows.Add();
            foreach (XmlNode thoigian in DSthoigian)
            {
                XmlNode nam = thoigian.SelectSingleNode("@nam");
                XmlNodeList DScongty = thoigian.SelectNodes("congty");
                foreach (XmlNode congty in DScongty)
                {
                    XmlNode ten = congty.SelectSingleNode("@ten");
                    XmlNode xuatxuong = congty.SelectSingleNode("xuatxuong");
                    XmlNode thiphan = congty.SelectSingleNode("thiphan");

                    //nam.InnerText = txtnam.Text;
                    //ten.InnerText = txtten.Text;
                    //xuatxuong.InnerText = txtxuatxuong.Text;
                    //thiphan.InnerText = txtthiphan.Text;

                    data.Rows[i].Cells[0].Value = nam.InnerText;
                    data.Rows[i].Cells[1].Value = ten.InnerText;
                    data.Rows[i].Cells[2].Value = xuatxuong.InnerText;
                    data.Rows[i].Cells[3].Value = thiphan.InnerText;

                    data.Rows.Add();
                    i++;
                }
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlElement thoigian = doc.CreateElement("thoigian");
            XmlAttribute nam = doc.CreateAttribute("nam");
            XmlElement congty = doc.CreateElement("congty");
            XmlAttribute ten = doc.CreateAttribute("ten");
            XmlElement xuatxuong = doc.CreateElement("xuatxuong");
            XmlElement thiphan = doc.CreateElement("thiphan");
        
            nam.InnerText = txtnam.Text;
            ten.InnerText = txtten.Text;
            xuatxuong.InnerText = txtxuatxuong.Text;
            thiphan.InnerText = txtthiphan.Text;

            XmlNodeList DSthoigian = root.SelectNodes("/sanxuatdienthoai/thoigian");
            foreach (XmlNode temp_thoigian in DSthoigian)
            {
                XmlNode temp_nam = temp_thoigian.SelectSingleNode("@nam");
                if(temp_nam.InnerText == nam.InnerText)
                {
                    XmlNodeList DScongty = temp_thoigian.SelectNodes("congty");
                    foreach(XmlNode temp_congty in DScongty)
                    {
                        XmlNode temp_ten = temp_congty.SelectSingleNode("@ten");
                        if(temp_ten.InnerText == ten.InnerText)
                        {
                            MessageBox.Show("Du lieu da ton tai!");
                            return;
                        }
                    }
                    temp_thoigian.AppendChild(congty);
                    congty.Attributes.Append(ten);
                    congty.AppendChild(xuatxuong);
                    congty.AppendChild(thiphan);
                    doc.Save(path);
                    HienThi();
                    return;
                }
                
            }
            root.AppendChild(thoigian);
            thoigian.Attributes.Append(nam);
            thoigian.AppendChild(congty);
            congty.Attributes.Append(ten);
            congty.AppendChild(xuatxuong);
            congty.AppendChild(thiphan);
            doc.Save(path);
            HienThi();

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtnam.Text = data.Rows[index].Cells[0].Value.ToString(); 
            txtten.Text = data.Rows[index].Cells[1].Value.ToString(); 
            txtxuatxuong.Text = data.Rows[index].Cells[2].Value.ToString(); 
            txtthiphan.Text = data.Rows[index].Cells[3].Value.ToString(); 
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon xoa dong nay khong", "Xac nhan xoa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                doc.Load(path);
                XmlElement root = doc.DocumentElement;
                XmlNode thoigian = root.SelectSingleNode("/sanxuatdienthoai/thoigian[@nam='" + txtnam.Text + "']");
                XmlNode congty = thoigian.SelectSingleNode("congty[@ten='" + txtten.Text + "']");
                thoigian.RemoveChild(congty);   
                doc.Save(path);
                HienThi();

            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNodeList DSthoigian = root.SelectNodes("/sanxuatdienthoai/thoigian");
            int i = 0;
            data.Rows.Clear();
            data.Rows.Add();
            foreach (XmlNode thoigian in DSthoigian)
            {
                XmlNode nam = thoigian.SelectSingleNode("@nam");
                if (nam.InnerText == txtnam.Text)
                {
                    XmlNodeList DScongty = thoigian.SelectNodes("congty");
                    foreach (XmlNode congty in DScongty)
                    {
                        XmlNode ten = congty.SelectSingleNode("@ten");
                        XmlNode xuatxuong = congty.SelectSingleNode("xuatxuong");
                        XmlNode thiphan = congty.SelectSingleNode("thiphan");

                        //nam.InnerText = txtnam.Text;
                        //ten.InnerText = txtten.Text;
                        //xuatxuong.InnerText = txtxuatxuong.Text;
                        //thiphan.InnerText = txtthiphan.Text;

                        data.Rows[i].Cells[0].Value = nam.InnerText;
                        data.Rows[i].Cells[1].Value = ten.InnerText;
                        data.Rows[i].Cells[2].Value = xuatxuong.InnerText;
                        data.Rows[i].Cells[3].Value = thiphan.InnerText;

                        data.Rows.Add();
                        i++;
                    }
                }
            }
            if (data.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Meo co du lieu nao ca!");
            }
        }
    }
}
