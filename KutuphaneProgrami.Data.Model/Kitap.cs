using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami.Data.Model
{
    public class Kitap:BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad{ get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string SiraNo { get; set; }
        [Required]
        public int Adet { get; set; }
        [Required]
        public DateTime EklenmeTarihi { get; set; }
        [Required]
        public int YazarId{ get; set; }       
        public virtual Yazar Yazar { get; set; }        
        public virtual List<Kategori> Kategoriler { get; set; }
        
    }
}
