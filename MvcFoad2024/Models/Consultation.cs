using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    [Table("td_consultation")]
    public class Consultation
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Appréciations"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "La taille maximale est de 2000 caractères.")]
        public string Appreciation { get; set; }

        [ForeignKey("Memoire")]
        public int MemoireId { get; set; }
        public Memoire Memoire { get; set; }

        [ForeignKey("Utilisateur")]
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}