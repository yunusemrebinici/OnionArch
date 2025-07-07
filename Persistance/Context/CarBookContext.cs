using Domain.Entities;
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
		public DbSet<RentAcar> RentAcars { get; set; }
		public DbSet<RentAcarProcess> RentAcarProcesses { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Reservation> Reservations { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Reservation>()

				.HasOne(x => x.StartLocation)
				.WithMany(y => y.StartLocationList)
				.HasForeignKey(x => x.StartLocationID)
				.OnDelete(DeleteBehavior.ClientSetNull);
				;

			modelBuilder.Entity<Reservation>()
				.HasOne(x => x.EndLocation)
				.WithMany(y => y.EndLocationList)
				.HasForeignKey(x => x.EndLocationID)
				.OnDelete(DeleteBehavior.ClientSetNull);

			
		
			// CarPricing tablosu için bileşik benzersiz kısıtlama ekleme
			modelBuilder.Entity<CarPricing>()
				.HasIndex(cp => new { cp.CarID, cp.PricingID }) // Hangi sütunların benzersiz olacağını belirt
				.IsUnique(); // Bu indeksin benzersiz olacağını belirt

			// Eğer CarPricingID'yi birincil anahtar olarak kullanmıyorsanız
			// ve (CarID, PricingID) ikilisini birincil anahtar yapmak istiyorsanız:
			// modelBuilder.Entity<CarPricing>()
			//    .HasKey(cp => new { cp.CarID, cp.PricingID });

			modelBuilder.Entity<CarFeature>()
				.HasIndex(cf=>new { cf.CarID,cf.FeatureID})
				.IsUnique();
		}
	}
}
