using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCsupplementler.Models
{
    public class supplementveriler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aroma { get; set; }
        public int KG { get; set; }
        public long Fiyat { get; set; }



        public static List<supplementveriler> VeriListe = new List<supplementveriler>
        {
            new supplementveriler
            {
                Id=1,
                Ad="HardLine",
                Aroma="KAKOA,MUZ,ÇİLEK",
                KG=4,
                Fiyat=500,

            },
            new supplementveriler
            {
                Id=2,
                Ad="L-Karnitin",
                Aroma="PORTAKAL",
                KG=1,
                Fiyat=200,

            },

        };
    }
}