using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    [Table("td_document")]
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nom"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string Nom { get; set; }
        [Display(Name = "Extension"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string Extension { get; set; }

        public int? IdMemoire { get; set; }
        [ForeignKey("IdMemoire")]
        public virtual Memoire Memoire { get; set; }

    }
}