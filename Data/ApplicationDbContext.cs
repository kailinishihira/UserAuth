using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserRolePractice.Models;

namespace UserRolePractice.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder
			.UseMySql(@"Server=localhost;Port=8889;database=userrolepractice;uid=root;pwd=root;");
    }
}
