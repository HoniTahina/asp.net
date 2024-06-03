using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Lecteur:Utilisateur
    {
        [Display(Name = "Specialite"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "La taille maximale est de 100 caractères.")]
        public String Specialitee { get; set; }
        public virtual ICollection<Consultation> Consultation { get; set; }
        public virtual ICollection<Commentaire> Commentaire { get; set; }
    }
}