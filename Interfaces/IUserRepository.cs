using DatingApp.DTOs;
using DatingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Interfaces
{
    public interface IUserRepository
    {
      public  void update(AppUser user);
      public  Task<bool> SaveAllAsync();
      public  Task<List<AppUser>> GetUserAsync();
       public Task<AppUser> GetUserByIdAsync(int id);
       public Task<AppUser> GetUserByUsernameAsync(string username);
      public  Task<List<MemberDto>> GetMembersAsync();
       public Task<MemberDto> GetMemberAsync(string username);
    }
}
