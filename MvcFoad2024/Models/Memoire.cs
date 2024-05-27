using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MvcFoad2024.Models
{
    [Table("td_memoire")]
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }
        [Display(Name = "Annee du memoire"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "Trop long")]
        public string Annee { get; set; }
        [Display(Name = "Titre memoire"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long")]
        public string Nom { get; set; }
        [Display(Name = "Niveau"), Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "Trop long")]
        public string Niveau { get; set; }
        [Display(Name = "Specialite"), Required(ErrorMessage = "*"), MaxLength(150, ErrorMessage = "Trop long")]
        public string Specialite { get; set; }
        [Display(Name = "Description"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "Trop long")]
        public string Description { get; set; }
        [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string etat {  get; set; }
        public int noteFinale { get; set; }
        [Display(Name = "Appreciation"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string appreciation { get; set; }
        [Display(Name = "Verdict"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string verdict {  get; set; }

        public int DocumentId { get; set; }
        public Document Document { get; set; }

        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public ICollection<MemoireAuteur> MemoireAuteurs { get; set; }
        public ICollection<Commentaire> Commentaires { get; set; }
        public ICollection<Consultation> Consultations { get; set; }


    }
}