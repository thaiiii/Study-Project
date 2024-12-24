using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using cuoiki0.Models;

namespace cuoiki0.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public List<DanhMuc> LayDanhMuc()
        {
            return db.DanhMuc.ToList();
        }
    }
}
