using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    [Table("td_commentaire")]
    public class Commentaire
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Contenu"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "La taille maximale est de 2000 caractères.")]
        public string Contenu { get; set; }

        [ForeignKey("Utilisateur")]
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        [ForeignKey("Memoire")]
        public int MemoireId { get; set; }
        public Memoire Memoire { get; set; }
    }
}