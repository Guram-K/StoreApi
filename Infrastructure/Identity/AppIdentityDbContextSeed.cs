using Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "g",
                    Email = "g@gmail.com",
                    UserName = "GK",
                    Address = new Address
                    {
                        FirstName = "G",
                        LastName = "K",
                        Street = "temqa",
                        City = "Tbilisi",
                        ZipCode = "0921",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
