using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
		// Veri tabanı bağlantı kurma metodu.
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=TraversalDB;integrated security=true;");
		}

		// EntityLayer'daki sınıf isimleri - sql'e yansıyacak tablo isimleri
		public DbSet<About> Abouts { get; set; }
		public DbSet<About2> Abouts2s { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Feature2> Feature2s { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<SubAbout> SubAbouts { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
