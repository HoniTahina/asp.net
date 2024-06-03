using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Auteur:Utilisateur
    {
        [Required, Display(Name ="Ancienneté")]
        public int Anciennete { get; set; }
        public virtual ICollection<Memoire> Memoire { get; set; }

    }
}