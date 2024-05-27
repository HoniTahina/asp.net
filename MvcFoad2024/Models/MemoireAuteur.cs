using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    [Table("td_memoire_auteur")]
    public class MemoireAuteur
    {
        public int MemoireId { get; set; }
        public Memoire Memoire { get; set; }

        [ForeignKey("Utilisateur")]
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}