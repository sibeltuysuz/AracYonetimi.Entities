using AracYonetim.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//openclose yazdığın proje gelişime açık değişime açık değil
namespace AracYonetim.Entities.Models
{[Table("Araclar")]
   public class Arac
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(200)]
        //modeli fluent-apidede ayrıntıları tanımlanabilir.veya burda anotition  
        public string Model { get; set; }
        [Range(1850,2100)]
        public int UretimYili { get; set; }
        public Yakittipleri Yakittipi{ get; set; }
        public VitesTipleri Vitestipi { get; set; }
        public byte[] Fotograf { get; set; }
        public int MarkaId { get; set; }
        [ForeignKey("MarkaId")]
        public virtual Marka Markasi { get; set; }

        public override string ToString() => $"{this.Model}-{this.UretimYili}{this.Yakittipi}";
        //1 tane this yeterli

        


    }
}
