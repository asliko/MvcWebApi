using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApi.Models.MODEL
{
    public class Kategori
    {
        public string KategoriAdi { get; set; }
        public string KategoriAciklamasi { get; set; }
        public string KOluşturmaTarihi { get; set; }
        public string KDegistirmeTarihi { get; set; }
    }
}