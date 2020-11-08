using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using Antlr.Runtime.Tree;
using System.Data.Entity;
using AutoMapper;
using Tool_World.Dtos;
using Tool_World.Models;
using Tool_World.ViewModels;

namespace Tool_World.APi
{
    public class ToolRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public ToolRentalsController()
        {
           _context = new ApplicationDbContext();
        }

        [Authorize(Roles = RoleName.CanManageTools + "," + RoleName.CanManageRentals)]
        public IHttpActionResult GetRentals()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            var rentals = _context.Rentals.Include(r => r.Tool).ToList();
            var activeRentals = _context.Rentals.Include(r => r.Tool).Where(r => r.IsRentalActive == true);

            if (User.IsInRole(RoleName.CanManageRentals))
            {
                return Ok(activeRentals);
            }

            return Ok(rentals);


        }

        public IHttpActionResult GetRental(int id)
        {
            
            var toolRental = _context.Rentals
                .Include(r => r.Customer)
                .SingleOrDefault(r=> r.Id == id);

            if (toolRental == null)
                return NotFound();

            return Ok(Mapper.Map<Rental, ToolRentalDto>(toolRental));
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageTools + "," + RoleName.CanManageRentals)]
        public IHttpActionResult CreateNewToolRental(ToolRentalDto toolRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == toolRental.CustomerId);


            var tools = _context.Tools.Where(
                t =>toolRental.ToolIds.Contains(t.Id)).ToList();


            foreach (var tool in tools)
            {
                if (tool.NumberAvailable == 0)
                    return BadRequest("Tool isn't available for rent.");

                tool.NumberAvailable--;
                
                var rental = new Rental
                {
                    Customer = customer,
                    Tool = tool,
                    DateRented = DateTime.Now,
                    IsRentalActive = true
                   
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = RoleName.CanManageTools + "," + RoleName.CanManageRentals)]
        public IHttpActionResult UpdateRental(int id, ToolRentalDto toolRentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            var rentalInDb = _context.Rentals.Include(r => r.Tool).SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                return NotFound();

            rentalInDb.DateReturned = DateTime.Now;

            if (rentalInDb.Tool.NumberAvailable < rentalInDb.Tool.NumberInStock && rentalInDb.IsRentalActive == true)
            {
                rentalInDb.Tool.NumberAvailable++;
                rentalInDb.IsRentalActive = false;
            }

            Mapper.Map(toolRentalDto, rentalInDb);

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageTools)]
        public IHttpActionResult DeleteRental(int id)
        {
            var rentalInDb = _context.Rentals.Include(r => r.Tool).SingleOrDefault(r => r.Id == id);

           
            if (rentalInDb == null)
                return NotFound();

            rentalInDb.DateReturned = DateTime.Now;

            if (rentalInDb.Tool.NumberAvailable <= rentalInDb.Tool.NumberInStock)
            {
                rentalInDb.Tool.NumberAvailable++;
                
            }
            _context.Rentals.Remove(rentalInDb);

            _context.SaveChanges();

            return Ok();
        }
    }
}
