using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RFProjekt.Dnn.KeresoModulSivatagiHarco.Models
{
    public class MentettKeresés
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Név { get; set; }
        public string Kategória { get; set; }
        public string Terméktípús { get; set; }
        public string Nem { get; set; }

    }
}