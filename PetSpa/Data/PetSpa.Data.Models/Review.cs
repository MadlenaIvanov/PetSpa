using PetSpa.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetSpa.Data.Models
{
    public class Review : BaseDeletableModel<string>
    {

        public Review()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
