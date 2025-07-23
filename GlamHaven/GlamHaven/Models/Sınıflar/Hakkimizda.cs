using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlamHaven.Models.Sınıflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Baslık{ get; set; }
        [Required]
        public string Acıklama{ get; set; }
    }
}