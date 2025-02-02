using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Rehber.Models
{
    public class Kisi
    {
        public int KisiId { get; set; }

        public string Adi { get; set; }

        public string  Soyadi { get; set; }


        public KisiDetay KisiDetay { get; set; }

    }

}
