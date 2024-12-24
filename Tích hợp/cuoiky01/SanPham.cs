using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace cuoiky01
{
    public class SanPham
    {
        public int Ma {  get; set; }
        public string Ten { get; set; }
        public int DonGia { get; set; }
        public int MaDanhMuc{ get; set; }

    }
}
