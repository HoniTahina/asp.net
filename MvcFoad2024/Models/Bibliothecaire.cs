using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Bibliothecaire:Utilisateur
    {
        public string type { get; set; }
        public virtual ICollection<Memoire> Memoire { get; set; }

    }
}