﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
	public class CarBookContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EMRE\\SQLEXPRESS01;initial Catalog=CarBook;integrated Security=true;TrustServerCertificate=true;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Banner> Banners { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<CarDescription> CarDescriptions { get; set; }
		public DbSet<CarFeature> CarFeatures { get; set; }
		public DbSet<CarPricing> CarPricings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<FooterAddress> FooterAddresses { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Pricing> Pricings { get; set; }
		public DbSet<Services> Services { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<BlogTags> BlogTags { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Comment> Comments { get; set; }
	}
}
