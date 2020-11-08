using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Tool_World.Dtos;
using Tool_World.Models;

namespace Tool_World.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Mapping from Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Tool, ToolDto>();
            Mapper.CreateMap<Manufacturer, ManufacturerDto>();
            Mapper.CreateMap<ToolCategory, ToolCategoryDto>();
            Mapper.CreateMap<ToolDriveSize, ToolDriveSizeDto>();
            Mapper.CreateMap<Rental, ToolRentalDto>();
           


            // Mapping Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MembershipTypeDto, MembershipType>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            
            Mapper.CreateMap<ToolDto, Tool>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<ManufacturerDto, Manufacturer>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<ToolCategoryDto, ToolCategory>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<ToolDriveSizeDto, ToolDriveSize>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<ToolRentalDto, Rental>()
                .ForMember(r => r.Id, opt => opt.Ignore());
        }
    }
}