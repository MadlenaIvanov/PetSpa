using PetSpa.Data.Models;
using PetSpa.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetSpa.Web.ViewModels.Services.ViewModels
{
    public class AllServicesViewModel : IMapFrom<Service>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
