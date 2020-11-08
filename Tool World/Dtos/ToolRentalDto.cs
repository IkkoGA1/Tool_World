using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tool_World.Dtos
{
    public class ToolRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> ToolIds { get; set; }

        public ToolDto Tool { get; set; }

        public CustomerDto Customer { get; set; }

        public ManufacturerDto Manufacturer { get; set; }

        public bool IsActiveRental { get; set; }
    }
}