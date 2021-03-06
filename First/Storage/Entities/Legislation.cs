using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Legislation
    {
                  
        public int ID { get; set; }
        public string LegislationText { get; set; }

        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

    }
}
