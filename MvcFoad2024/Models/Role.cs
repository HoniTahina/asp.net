using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Role"), Required(ErrorMessage = "*"), MaxLength(30, ErrorMessage = "La taille maximale est de 30 caractères.")]
        public string Libelle { get; set; }

        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}