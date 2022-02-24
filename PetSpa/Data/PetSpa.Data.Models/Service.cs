using PetSpa.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSpa.Data.Models
{
    public class Service : BaseDeletableModel<string>
    {

        public Service()
        {
            Id = Guid.NewGuid().ToString();
            Salons = new List<Salon>();
            Appointments = new List<Appointment>();
        }

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public ICollection<Salon> Salons { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
