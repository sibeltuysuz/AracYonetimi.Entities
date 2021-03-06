﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetim.Entities.Models
{[Table("Markalar")]
   public class Marka
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string MarkaAdi { get; set; }

        [Range(1850,2100,ErrorMessage ="kurulus yılı 1850-2100 arasında olabilir")]
        public int KurulusYili { get; set; }
        public string Ulke { get; set; }

        public string Kurucusu { get; set; }
        public byte[] Logo { get; set; }
        public virtual List<Arac> Araclar { get; set; } = new List<Arac>();
        public override string ToString() => $"{this.MarkaAdi}";
        //to string i ezdik
       

    }
}
