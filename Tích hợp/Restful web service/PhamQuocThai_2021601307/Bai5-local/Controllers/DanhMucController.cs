using Bai5_local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai5_local.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]//Lấy dữ liệu 
        public List<DanhMuc> LayDM()
        {
            return db.DanhMucs.ToList();
        }
    }
}
