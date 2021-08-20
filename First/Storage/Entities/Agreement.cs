using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Agreement
    {
        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Company1ID))]
        public int Company1ID { get; set; }
        public virtual Company Company1 { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey(nameof(Company2ID))]
        public int Company2ID { get; set; }
        public virtual Company Company2 { get; set; }

        public string Date { get; set; }
        public string AgreementText { get; set; }

    }
}
