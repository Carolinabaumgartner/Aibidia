using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First.Storage.Entities
{
    public class Agreement
    {
        [ForeignKey(nameof(Company1ID))]
        public int Company1ID { get; set; }
        public virtual Country Country1 { get; set; }

        [ForeignKey(nameof(Company2ID))]
        public int Company2ID { get; set; }
        public virtual Country Country2 { get; set; }

        public int Date { get; set; }
        public int AgreementText { get; set; }

    }
}
