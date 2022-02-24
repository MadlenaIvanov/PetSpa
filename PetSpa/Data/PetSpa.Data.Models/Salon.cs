namespace PetSpa.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using PetSpa.Data.Common.Models;

    public class Salon : BaseDeletableModel<string>
    {
        public Salon()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public string NameOfSalon { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string GroomerName { get; set; }



    }
}
