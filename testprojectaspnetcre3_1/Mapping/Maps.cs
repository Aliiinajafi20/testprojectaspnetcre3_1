using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojectaspnetcre3_1.Data;
using testprojectaspnetcre3_1.Models;

namespace testprojectaspnetcre3_1.Mapping
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Kala, DetailsViewModelKala>().ReverseMap();
            CreateMap<Kala, CreateViewModelKala>().ReverseMap();
            CreateMap<Customer, ViewModelCustomer>().ReverseMap();
            CreateMap<OrderApp, ViewModelOrderApp>().ReverseMap();
        }
    }
}
