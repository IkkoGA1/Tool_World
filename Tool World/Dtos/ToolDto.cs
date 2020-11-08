using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tool_World.Models;

namespace Tool_World.Dtos
{
    public class ToolDto
    {
        public int Id { get; set; }

       
        public string ModelName { get; set; }

        public string UrlPicLink { get; set; }

        public ManufacturerDto Manufacturer { get; set; }

        public int ManufacturerId { get; set; }

        public ToolCategoryDto ToolCategory { get; set; }

        public ToolDriveSizeDto ToolDriveSize { get; set; }

        public ToolRentalDto ToolRental { get; set; }

        public int ToolCategoryId { get; set; }

        public int ToolDriveSizeId { get; set; }

        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}