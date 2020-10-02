using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojectaspnetcre3_1.Data;

namespace testprojectaspnetcre3_1.Models
{
    public class ViewModelOrderApp
    {
        public int Id { get; set; }

       
        public ViewModelCustomer Customer { get; set; }
        public string CustomerId { get; set; }


        public DetailsViewModelKala Kala { get; set; }
        public int KalaId { get; set; }

        public IEnumerable<SelectListItem> CustomerSelectListItem { get; set; }
        public IEnumerable<SelectListItem> KalaSelectListItem { get; set; }

        public int Tadad { get; set; }
        public int KalaPrice { get; set; }
        public int KalaAll { get; set; }
        public string DataSabt { get; set; }
        public string DataTime { get; set; }
    }
}
