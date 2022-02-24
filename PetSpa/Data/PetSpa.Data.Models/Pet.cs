using PetSpa.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSpa.Data.Models
{
    public class Pet : BaseDeletableModel<string>
    {
        public Pet()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [StringLength(36)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
    }
}
