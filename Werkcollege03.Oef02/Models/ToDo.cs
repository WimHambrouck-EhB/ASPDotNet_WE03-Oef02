using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef02.Models
{
    public class ToDo
    {
        public ToDo()
        {
            Datum = DateTime.Now;
            // seconden en milliseconden op 0 zetten (we gaan er vanuit dat gebruikers to-dos niet op de seconde of milliseconde willen plannen)
            Datum = Datum.AddMilliseconds(-Datum.Millisecond).AddSeconds(-Datum.Second);
        }
        public int ID { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; private set; }
        [DataType(DataType.MultilineText)]
        public string Omschrijving { get; set; }
    }
}
