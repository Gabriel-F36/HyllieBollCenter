﻿using HyllieBollCenter.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace HyllieBollCenter.Data
{
	public class Seed
	{
		public static void SeedData(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				if (!context.Tenniss.Any())
				{
					context.Tenniss.AddRange(new List<Tennis>()
					{
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						},
						new Tennis()
						{
							NineToElevenId = null,
							ElevenToThirteenId = null,
							ThirteenToFifteenId = null,
							FifteenToSeventeenId = null,
							SeventeenToNineteenId = null
						}
					});
					context.SaveChanges();
				}
				
			}
		}

		public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				//Roles
				var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

				if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
				if (!await roleManager.RoleExistsAsync(UserRoles.User))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

				//Users
				var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
				string adminUserEmail = "admin@gmail.com";

				var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
				if (adminUser == null)
				{
					var newAdminUser = new AppUser()
					{
						UserName = "app-admin",
						Email = adminUserEmail,
						EmailConfirmed = true
					};
					await userManager.CreateAsync(newAdminUser, "Coding@1234?");
					await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
				}

				string appUserEmail = "user@gmail.com";

				var appUser = await userManager.FindByEmailAsync(appUserEmail);
				if (appUser == null)
				{
					var newAppUser = new AppUser()
					{
						UserName = "app-user",
						Email = appUserEmail,
						EmailConfirmed = true
					};
					await userManager.CreateAsync(newAppUser, "Coding@1234?");
					await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
				}
			}
		}
	}
}


