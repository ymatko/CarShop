﻿using CarShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
	public class AppDBContent : DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{

		}
		public DbSet<Car> Car { get; set; }
		public DbSet<Category> Category {get; set; }
	}
}
