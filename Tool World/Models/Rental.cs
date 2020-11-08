using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tool_World.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Tool Tool { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public ToolCategory ToolCategory { get; set; }

        public ToolDriveSize ToolDriveSize { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }

        public bool IsRentalActive { get; set; }
    }
}