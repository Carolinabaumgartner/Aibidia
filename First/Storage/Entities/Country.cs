using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Country
    {

        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(ContinentID))]
        public int ContinentID { get; set; }
        public virtual Continent Continent { get; set; }
    }
}
