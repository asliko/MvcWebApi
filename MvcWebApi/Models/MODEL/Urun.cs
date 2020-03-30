using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApi.Models.MODEL
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public string KategoriId { get; set; }

        public string UrunAciklamasi { get; set; }
        public string UOluşturmaTarihi { get; set; }
        public string UDegistirmeTarihi { get; set; }
    }
}