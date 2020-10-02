using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcre3_1.Models
{
    public class DetailsViewModelKala
    {
        [Key]
        public int KalaId { get; set; }
        [Required]
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }


    }
    public class CreateViewModelKala
    {

        [Required]
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }


    }
}
