using PetSpa.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSpa.Data.Models
{
    public class Appointment : BaseDeletableModel<string>
    {
        public Appointment()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime Time { get; set; }
        public DateTime Date { get; set; }

        public string SalonAddress { get; set; }

        //add the pet
    }
}
