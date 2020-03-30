using MvcWebApi.Models.DBModel;
using MvcWebApi.Models.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    public class ProductController : ApiController
    {
        WebApiDBEntities1 db = new WebApiDBEntities1();
        public List<Urun> GetUrun()
        {
            //Tüm kategorileri getir demem gerek
            List<Urun> Urun = db.Product.Select(x => new Urun()
            {
                UrunAdi = x.ProductName,
                UrunAciklamasi = x.ProductDescription.ToString(),
                KategoriId = x.CategoryID.ToString(),
                UOluşturmaTarihi = x.ProductCreateTime.ToString(),
                UDegistirmeTarihi=x.ProductModifiedTime.ToString()

            }).ToList();

            return Urun;

        }

        [HttpGet]
        public Urun Get(int id)
        {
            Product pt = db.Product.Find(id);
            Urun u = new Urun();
            u.UrunAdi = pt.ProductName;
            u.UrunAciklamasi = pt.ProductDescription.ToString();
            u.KategoriId = pt.CategoryID.ToString();
            u.UOluşturmaTarihi = pt.ProductCreateTime.ToString();
            u.UDegistirmeTarihi = pt.ProductModifiedTime.ToString();
            return u;
        }




    }
}
