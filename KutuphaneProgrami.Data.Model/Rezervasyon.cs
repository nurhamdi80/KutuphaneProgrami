using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami.Data.Model
{
    public class Rezervasyon : BaseEntity
    {
        [Required]
        public int KitapId { get; set; }
        [Required]
        public int UyeId { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [Required]
        public string RezervasyonDurum { get; set; }
    }
}

