using CoureTechnologies.Interface;
using CoureTechnologies.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechnologies.Repository
{
    public class UserRepository : GenericRepository <User>, IUser
    {

        public UserRepository(CountryDbContext context) : base(context) 
        {
        
        }

        public async Task<IEnumerable> UserCheck (User user)
        {
            try
            {
                 var res = await _context.User
                   .Where(c => c.PhoneNumber == user.PhoneNumber)
                   .FirstOrDefaultAsync();

                return (IEnumerable)user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
