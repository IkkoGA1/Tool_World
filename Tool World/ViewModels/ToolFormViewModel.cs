using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tool_World.Models;

namespace Tool_World.ViewModels
{
    public class ToolFormViewModel
    {
        public IEnumerable<Manufacturer> Manufacturers { get; set; }

        public int? Id { get; set; }

        [Display(Name = "Model")]
        [Required]
        public string ModelName { get; set; }

        [Required]
        [Display(Name = "Tool Image Url")]
        public string UrlPicLink { get; set; }

        [Required]
        public Manufacturer Manufacturer { get; set; }

        [Required]
        [Display(Name = "Manufacturer Type")]
        public int? ManufacturerId { get; set; }

        [Required]
        public ToolCategory ToolCategory { get; set; }

        [Required]
        [Display(Name = "Tool Category Type")]
        public int? ToolCategoryId { get; set; }

        [Required]
        [Display(Name = "Drive")]
        public ToolDriveSize ToolDriveSize { get; set; }

        [Required]
        [Display(Name = "Drive Size")]
        public int? ToolDriveSizeId { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        [Required]
        public byte? NumberAvailable { get; set; }

        public IEnumerable<ToolCategory> ToolCategories { get; set; }
        public IEnumerable<ToolDriveSize> ToolDriveSizes { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Tool" : "New";
            }
        }

        public ToolFormViewModel()
        {
            Id = 0;
        }
        public ToolFormViewModel(Tool tool)
        {
            Id = tool.Id;
            ModelName = tool.ModelName;
            UrlPicLink = tool.UrlPicLink;
            ManufacturerId = tool.ManufacturerId;
            ToolCategoryId = tool.ToolCategoryId;
            ToolDriveSizeId = tool.ToolDriveSizeId;
            NumberInStock = tool.NumberInStock;
        }
    }
}