using MVC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string BrojIndexa { get; set; }

        //oboje dole neophodno da bi EF formirao vezu medju tabelama, a naziv property-a sa Id-em se formira tako sto na nziv klase/tabele dodaje Id (ne ID)
        //, ovo je za vezu 1:N (1 smjer : N studenata)
        public int SmjerId { get; set; }
        public Smjer Smjer { get; set; }

        // 1:1
        public Korisnik Korisnik { get; set; }
    }
}
