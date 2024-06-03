using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection.Emit;

namespace MvcFoad2024.Models
{

    public class BdPartagememoireContext : DbContext
    {
        public BdPartagememoireContext() : base("connPartageMemoiredb") 
        {

        }
        public DbSet<Memoire> memoires { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<MemoireAuteur> memoireAuteurs { get; set; }
        public DbSet<Document> documents { get; set; }
        public DbSet<Commentaire> commentaires { get; set; }
        public DbSet<Consultation> consultations { get; set; }
        public DbSet<Auteur> auteurs { get; set; }
        public DbSet<Lecteur> lecteurs { get; set; }
        public DbSet<Bibliothecaire> bibliothecaires { get; set; }
        public DbSet<Expert> experts { get; set; }

       

    }

}