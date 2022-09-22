using AutoMapper;
using DatingApp.Data;
using DatingApp.DTOs;
using DatingApp.Entities;
using DatingApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{    
    [Authorize]
       public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController (IUserRepository userRepository,IMapper mapper)
        {
          this._userRepository = userRepository;
            this._mapper = mapper;
        }
        [HttpGet]      
        public async Task<ActionResult<List<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();           

           return  Ok(users);
        }      
         [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        { 
           return  await _userRepository.GetMemberAsync(username);           
           
        }
    }
}
