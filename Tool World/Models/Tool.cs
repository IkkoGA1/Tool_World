using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tool_World.Models
{
    public class Tool
    {
        public int Id { get; set; }

        [Display(Name = "Model")]
        [Required]
        public string ModelName { get; set; }

        [Required]
        [Display(Name = "Tool Image Url")]
        public string UrlPicLink { get; set; }

        public Manufacturer Manufacturer { get; set; }

        [Display(Name = "Manufacturer Type")]
        public int ManufacturerId { get; set; }

       
        public ToolCategory ToolCategory { get; set; }

        [Display(Name = "Tool Category Type")]
        public int ToolCategoryId { get; set; }


        [Display(Name = "Drive")]
        public ToolDriveSize ToolDriveSize { get; set; }

        [Display(Name = "Drive Size")]
        public int ToolDriveSizeId { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }


        public byte NumberAvailable { get; set; }

        
    }
}