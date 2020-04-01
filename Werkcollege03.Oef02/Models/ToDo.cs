using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef02.Models
{
    public class ToDo
    {
        public ToDo()
        {
            Datum = DateTime.Now;
        }
        public int ID { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; private set; }
        public string Omschrijving { get; set; }
    }
}
