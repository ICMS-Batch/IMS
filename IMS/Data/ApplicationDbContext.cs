using System;
using Microsoft.EntityFrameworkCore;
using IMS.Models.Entities;
namespace IMS.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{

		}
        public DbSet<User> Users { get; set; }
    }

	
}

