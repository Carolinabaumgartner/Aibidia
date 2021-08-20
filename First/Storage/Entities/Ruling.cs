using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Ruling
    {
                   
        public int ID { get; set; }

        [ForeignKey(nameof(CompanyID))]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public string Date { get; set; }
        public string RulingText { get; set; }

    }
}
