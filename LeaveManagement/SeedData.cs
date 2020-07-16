using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement
{
    public static class SeedData
    {
        public static void Seed(UserManager<Employee> userManager,RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<Employee> userManager)
        {
            //var users = userManager.GetUsersInRoleAsync("Employee").Result;
            if (userManager.FindByNameAsync("admin@localhost.com").Result==null)
            {
                var user = new Employee
                {
                    UserName = "admin@localhost.com",
                    Email="admin@localhost.com",
                    FirstName="Adminstrator"
                };
                IdentityResult result = userManager.CreateAsync(user, "P@ssword1").Result;
                //var result = userManager.CreateAsync(user, "P@ssword1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole{
                  Name= "Administrator"
                };

                IdentityResult roleResult = roleManager.
               CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Employee"
                };

                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }

    }
}
