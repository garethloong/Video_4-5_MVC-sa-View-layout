using MVC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class AkademskaGodina : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Opis { get; set; }
    }
}
