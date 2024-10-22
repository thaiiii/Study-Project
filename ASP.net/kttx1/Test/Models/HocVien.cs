using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class HocVien
    {
        //thuoc tinh 
        public string mahv {  get; set; }
        public string hoten { get; set; }
        public float diemthi { get; set; }
        public float uutien { get; set; }

        //constructor
        public HocVien()
        {
            mahv = "";
            hoten = "";
            diemthi = 0;
            uutien = 0;
        }

        public HocVien(string mahv, string hoten, float diemthi, float uutien)
        {
            this.mahv = mahv;
            this.hoten = hoten;
            this.diemthi = diemthi;
            this.uutien = uutien;
        }

        public float TongDiem()
        {
            return diemthi + uutien;
        }
    }
}