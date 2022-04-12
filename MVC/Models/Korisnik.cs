
using MVC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Korisnik : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Student Student { get; set; }
        public Referent Referent { get; set; }
        public Nastavnik Nastavnik { get; set; }
        public DateTime? DatumRodjenja { get; internal set; }
    }
}
