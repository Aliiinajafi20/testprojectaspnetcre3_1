using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcre3_1.Data
{
    public class OrderApp
    {
        public int Id { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        [ForeignKey("KalaId")]
        public Kala Kala { get; set; }
        public int KalaId { get; set; }

        public int Tadad { get; set; }
        public int KalaPrice { get; set; }
        public int KalaAll { get; set; }
        public string DataSabt { get; set; }
        public string DataTime { get; set; }
    }
}
