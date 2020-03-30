using MvcWebApi.Models;
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
    public class CategoryController : ApiController
    {

        WebApiDBEntities1 db = new WebApiDBEntities1();


        public List<Kategori> GetKategori()
        {
            List<Kategori> Kategori = db.Category.Select(x => new Kategori()
            {
                KategoriAdi = x.CategoryName,
                KategoriAciklamasi = x.CategoryDescription,
                KOluşturmaTarihi = x.CategoryCreateTime.ToString(),
                KDegistirmeTarihi=x.CategoryModifiedTime.ToString()


            }).ToList();

            return Kategori;

        }

        [HttpGet]
        public Kategori Get(int id)
        {
            Category kat = db.Category.Find(id);
            Kategori k = new Kategori();
            k.KategoriAdi = kat.CategoryName;
            k.KategoriAciklamasi = kat.CategoryDescription;
            k.KOluşturmaTarihi = kat.CategoryCreateTime.ToString();
            k.KDegistirmeTarihi = kat.CategoryModifiedTime.ToString();
            return k;
        }

        [HttpDelete]
        public string Sil(int id)
        {
            Category cat = db.Category.Where(x => x.CategoryID == id).FirstOrDefault();
            db.Category.Remove(cat);
            db.SaveChanges();
            return "Başarılı";
        }

        //Post

         public Kategori KategoriKaydet(Kategori cat)
         {
         Category c = new Category();
         c.CategoryName = cat.KategoriAdi;
         c.CategoryDescription = cat.KategoriAciklamasi;
         c.CategoryCreateTime = DateTime.Now;
         c.CategoryModifiedTime = DateTime.Now;
         db.Category.Add(c);
         db.SaveChanges();
           return cat;
        }




    }
}
