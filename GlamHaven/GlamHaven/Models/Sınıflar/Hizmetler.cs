using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlamHaven.Models.Sınıflar
{
    public class Hizmetler
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Baslık1 { get; set; }
        [Required]
        public string Acıklama1 { get; set; }
        [Required]
        public string Baslık2 { get; set; }
        [Required]
        public string Acıklama2 { get; set; }
        [Required]
        public string Baslık3 { get; set; }
        [Required]
        public string Acıklama3 { get; set; }
        
    }
}