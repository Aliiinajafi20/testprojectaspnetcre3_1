using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcre3_1.Models
{
    public class DetailsViewModelKala
    {
        [Display(Name ="کد کالا")]
        public int KalaId { get; set; }
        [Display(Name = "نام کالا")]
        public string KalaName { get; set; }
        [Display(Name = "قیمت کالا")]
        public int KalaPrice { get; set; }


    }
    public class CreateViewModelKala
    {

        [Required]
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }


    }
}
