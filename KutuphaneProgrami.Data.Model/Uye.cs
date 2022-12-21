using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami.Data.Model
{
    public class Uye : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Soyad { get; set; }
        [Required]
        [Column(TypeName = "char")]
        [MaxLength(11), MinLength(11)]
        public string Tc { get; set; }
        
        [Column(TypeName = "char")]
        [MaxLength(11), MinLength(11)]
        public string Tel { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Mail { get; set; }
        [Column(TypeName = "char")]
        [MaxLength(32), MinLength(32)]
        public string Sifre { get; set; }
        [Required]
        public int Ceza { get; set; }
                       
        [Required]
        public DateTime KayitTarihi { get; set; }
      
        [Column(TypeName = "char")]
        [MaxLength(1), MinLength(1)]
        public string Yetki { get; set; }
        public List<OduncKitap> OduncKitaplar { get; set; }


    }
}

