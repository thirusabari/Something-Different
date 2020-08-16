using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Model
{
	public partial class CRUDContext : DbContext
	{
		public DbSet<UserLoginInfo> UserLoginInfo { get; set; }
		public DbSet<IDCardDetails> IdCardDetails { get; set; }
		public DbSet<StudentIDInfo> StudentIDInfo { get; set; }

		public DbSet<EmployeeIDInfo> EmployeeIDInfo { get; set; }
		

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server =.; Database=CRUD; User ID=sa;Password=sa123; Integrated Security = True");
		}
	}
}
