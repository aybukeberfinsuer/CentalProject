﻿using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Context
{
	public class CentalContext:IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-JKIESAIB;database=CentalDb;integrated security=true; trustServerCertificate=true;");

			optionsBuilder.UseLazyLoadingProxies();// tüm ilişkili tablolarda propların başına virtual kelimesini eklemek gerekiyor.

		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<Banner> Banner { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Process> Processes { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
