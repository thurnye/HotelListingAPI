using HotelListingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.DataAccess.Data
{
	public class HotelListingDbContext : DbContext
	{
		public HotelListingDbContext(DbContextOptions options) : base(options)
        {

		}

		/// <summary>
		/// Hotels db set
		/// </summary>
		public DbSet<Hotel> Hotels { get; set; }

		/// <summary>
		/// Countries DB set
		/// </summary>
		public DbSet<Country> Countries { get; set; }
	}
}

