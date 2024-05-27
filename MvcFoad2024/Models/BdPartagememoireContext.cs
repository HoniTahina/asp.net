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
        public DbSet<Role> roles { get; set; }
        public DbSet<MemoireAuteur> memoireAuteurs { get; set; }
        public DbSet<Document> documents { get; set; }
        public DbSet<Commentaire> commentaires { get; set; }
        public DbSet<Consultation> consultations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MemoireAuteur>()
                .HasKey(ma => new { ma.MemoireId, ma.UtilisateurId });

            modelBuilder.Entity<MemoireAuteur>()
           .HasRequired(ma => ma.Memoire)
           .WithMany(m => m.MemoireAuteurs)
           .HasForeignKey(ma => ma.MemoireId)
           .WillCascadeOnDelete(false);

            modelBuilder.Entity<MemoireAuteur>()
                .HasRequired(ma => ma.Utilisateur)
                .WithMany(u => u.MemoireAuteurs)
                .HasForeignKey(ma => ma.UtilisateurId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Commentaire>()
                .HasRequired(c => c.Utilisateur)
                .WithMany(u => u.Commentaires)
                .HasForeignKey(c => c.UtilisateurId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Commentaire>()
                .HasRequired(c => c.Memoire)
                .WithMany(m => m.Commentaires)
                .HasForeignKey(c => c.MemoireId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Consultation>()
                .HasRequired(co => co.Utilisateur)
                .WithMany(u => u.Consultations)
                .HasForeignKey(co => co.UtilisateurId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Consultation>()
                .HasRequired(co => co.Memoire)
                .WithMany(m => m.Consultations)
                .HasForeignKey(co => co.MemoireId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Memoire>()
                .HasRequired(m => m.Utilisateur)
                .WithMany(u => u.Memoires)
                .HasForeignKey(m => m.UtilisateurId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Memoire>()
                .HasRequired(m => m.Document)
                .WithMany(d => d.Memoires)
                .HasForeignKey(m => m.DocumentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilisateur>()
                .HasRequired(u => u.Role)
                .WithMany(r => r.Utilisateurs)
                .HasForeignKey(u => u.RoleId)
                .WillCascadeOnDelete(false);
        }

    }

}