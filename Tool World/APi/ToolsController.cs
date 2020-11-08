using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Tool_World.Dtos;
using Tool_World.Models;
using Tool_World.ViewModels;

namespace Tool_World.APi
{
    public class ToolsController : ApiController
    {
        private ApplicationDbContext _context;

        public ToolsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetTools(string query = null)
        {

            var toolCategoryDto = _context.Tools.Include(t => t.ToolCategory)
                .ToList().Where(t => t.NumberAvailable > 0);

            var toolDriveSizeDto = _context.Tools.Include(t => t.ToolDriveSize)
                .ToList();

            var toolsQuery = _context.Tools.Include(t => t.Manufacturer);

            if (!String.IsNullOrWhiteSpace(query))
                toolsQuery = toolsQuery.Where(t => t.ModelName.Contains(query));

            var toolDto = toolsQuery
                .ToList()
                .Select(Mapper.Map<Tool, ToolDto>);

            return Ok(toolDto);
            
        }

        

        public IHttpActionResult GetTool(int id)
        {
            var tool = _context.Tools.SingleOrDefault(t => t.Id == id);

            if (tool == null)
                return NotFound();

            return Ok(Mapper.Map<Tool, ToolDto>(tool));
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageTools)]
        public IHttpActionResult CreateTool(ToolDto toolDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tool = Mapper.Map<ToolDto, Tool>(toolDto);
            _context.Tools.Add(tool);
            _context.SaveChanges();

            toolDto.Id = tool.Id;

            return Created(new Uri(Request.RequestUri + "/" + tool.Id), toolDto);
        }

        [HttpPut]
        [Authorize(Roles = RoleName.CanManageTools)]
        public IHttpActionResult UpdateTool(int id, ToolDto toolDto )
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var toolInDb = _context.Tools.SingleOrDefault(t => t.Id == id);

            if (toolInDb == null)
                return NotFound();

            Mapper.Map(toolDto, toolInDb);

            _context.SaveChanges();

            return Ok();

        }

        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageTools)]
        public IHttpActionResult DeleteTool(int id)
        {
            var toolInDb = _context.Tools.SingleOrDefault(t => t.Id == id);

            if (toolInDb == null)
                return NotFound();

            _context.Tools.Remove(toolInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
