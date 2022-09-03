using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
     [ApiController]
        [Route("api/[controller]")]
       public class UsersController : Controller
    {
        private readonly DataContext _context;
        public UsersController (DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
           return  Json( await _context.Users.ToListAsync());
        }
         [HttpGet("{id}")]
        public IActionResult GetUsers(int id)
        {
           return Json (_context.Users.FirstOrDefault(x=>x.Id==id));
        }
    }
}
