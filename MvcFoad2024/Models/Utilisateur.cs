using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{

    [Table("td_utilisateur")]
    public class Utilisateur
    {
            [Key]
            public int IdUtilisateur { get; set; }
            [Display(Name = "Nom"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long")]
            public string Nom { get; set; }
            [Display(Name = "Prenom"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long")]
            public string Prenom { get; set; }
            [Display(Name = "Telephone"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long")]
            public string Telephone { get; set; }
            [Display(Name = "Email"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long"), DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Display(Name = "mot de passe"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "Trop long"), DataType(DataType.Password)]
            public string motDePasse { get; set; }
            
            [Display(Name = "Matricule"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "Trop long")]
            public string Matricule { get; set; }
            [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "Trop long")]
            public string Etat { get; set; }
            [Display(Name = "Specialite"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "La taille maximale est de 100 caractères.")]
            public string Specialite { get; set; }

            public ICollection<MemoireAuteur> MemoireAuteurs { get; set; }
            public ICollection<Commentaire> Commentaires { get; set; }
            public ICollection<Consultation> Consultations { get; set; }
            public ICollection<Memoire> Memoires { get; set; }
    }
}