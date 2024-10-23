using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Second.Models
{
    public class NhanVien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        public double luong { get; set; }
        public double thuong {  get; set; }

        public NhanVien()
        {
            manv = "";
            hoten = "";
            luong = 0;
            thuong = 0;
        }

        public NhanVien(string manv, string hoten, double luong, double thuong)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.luong = luong;
            this.thuong = thuong;
        }

        public double TongThuNhap()
        {
            return luong + thuong;
        }
    }
}