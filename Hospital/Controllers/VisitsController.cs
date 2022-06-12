
using AutoMapper;
using Hospital.Application.Queries;
using Hospital.DbContextAndBuilders.ApiDbContext;
using Hospital.Entities;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    
    public class VisitsController : BaseController
    {
        
        [HttpGet]
        public async Task<IActionResult> GetVisits()
        {
            return HandleResult(await Mediator.Send(new GetVisits.Query()));
            
        }


    }
}
