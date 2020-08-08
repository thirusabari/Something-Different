using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Model
{
	public partial class CRUDContext : DbContext
	{
		public DbSet<IDCardDetails> IdCardDetails { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server =.; Database=CRUD; User ID=sa;Password=sa123; Integrated Security = True");
		}
	}
}
