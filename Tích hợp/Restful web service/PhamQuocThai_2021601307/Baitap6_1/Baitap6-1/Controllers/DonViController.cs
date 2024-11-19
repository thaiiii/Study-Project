using Baitap6_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Baitap6_1.Controllers
{
    public class DonViController : ApiController
    {
        QLLuongEntities1 db = new QLLuongEntities1 ();

        [HttpGet]
        public List<DonVi> LayDonVi()
        {
            return db.DonVis.ToList();
        }
        [HttpGet]
        public List<DonVi> LayDonViTheoTenDonVi(string tendonvi)
        {
            return db.DonVis.Where(x => x.TenDonVi == tendonvi).ToList();
        }
    }
}
