using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Company
    {

        public int ID { get; set; }

        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public int Name { get; set; }

    }
}
