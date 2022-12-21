using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami.Data.Model
{
    public class Kategori:BaseEntity
    {
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }

        public virtual List<Kitap> Kitaplar { get; set; }
    }
}

