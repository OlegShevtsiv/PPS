using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string UserAdminEmail = "oleg28skm@gmail.com";
            string UserAdminPassword = "_Aa123456UserAdmin";

            string LibraryAdminEmail = "LibAdmin@gmail.com";
            string LibraryAdminPassword = "_Aa123456LibraryAdmin";

            string UserAdminRole = "user admin";
            string LibraryAdminRole = "library admin";
            string UresRole = "user";
            if (await roleManager.FindByNameAsync(UserAdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(UserAdminRole));
            }
            if (await roleManager.FindByNameAsync(LibraryAdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(LibraryAdminRole));
            }
            if (await roleManager.FindByNameAsync(UresRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(UresRole));
            }
            if (await userManager.FindByNameAsync(UserAdminEmail) == null)
            {
                User UserAdmin = new User { Name = "Oleg Shevtsiv UserAdmin", Email = UserAdminEmail, UserName = UserAdminEmail };
                IdentityResult result = await userManager.CreateAsync(UserAdmin, UserAdminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(UserAdmin, UserAdminRole);
                }
            }
            if (await userManager.FindByNameAsync(LibraryAdminEmail) == null)
            {
                User LibraryAdmin = new User { Name = "Jhon Smow UserAdmin", Email = LibraryAdminEmail, UserName = LibraryAdminEmail };
                IdentityResult result = await userManager.CreateAsync(LibraryAdmin, LibraryAdminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(LibraryAdmin, LibraryAdminRole);
                }
            }
        }
    }
}
