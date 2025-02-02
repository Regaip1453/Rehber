using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Rehber.Models
{
    public class KisiDetay
    {
        public int KisiDetayId { get; set; }
        public string TcKimlik { get; set; }
        public string TelNo { get; set; }

        public string Adres { get; set; }
        public int KisiId { get; set; }
        public Kisi kisiler { get; set; }


    }
}
