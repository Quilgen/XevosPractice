using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XevosPractice.Models;

namespace XevosPractice.DataLayer
{
	public class EmployeeContext : DbContext 
	{
		public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
		{}

		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//remove automatic ID value generating
			modelBuilder.Entity<Employee>().Property(p => p.Id).ValueGeneratedNever();
		}
	}
}
