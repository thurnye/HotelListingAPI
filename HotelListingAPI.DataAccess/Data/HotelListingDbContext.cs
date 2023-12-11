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


        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                  new Country
                 {
                     Id = 4,
                     Name = "Antigua and Barbuda",
                     ISOCode = "ATG"
                 },
                  new Country
                  {
                      Id = 5,
                      Name = "Anguilla",
                      ISOCode = "AIA"
                  },
                  new Country
                  {
                      Id = 14,
                      Name = "Aruba",
                      ISOCode = "ABW"
                  },
                  new Country
                  {
                      Id = 18,
                      Name = "Barbados",
                      ISOCode = "BRB"
                  },
                  new Country
                  {
                      Id = 26,
                      Name = "Saint Barthélemy",
                      ISOCode = "BLM"
                  },
                  new Country
                  {
                      Id = 27,
                      Name = "Bermuda",
                      ISOCode = "BMU"
                  },
                  new Country
                  {
                      Id = 30,
                      Name = "Bonaire, Sint Eustatius and Saba",
                      ISOCode = "BES"
                  },
                  new Country
                  {
                      Id = 32,
                      Name = "Bahamas",
                      ISOCode = "BHS"
                  },
                  new Country
                  {
                      Id = 37,
                      Name = "Belize",
                      ISOCode = "BLZ"
                  },
                  new Country
                  {
                      Id = 38,
                      Name = "Canada",
                      ISOCode = "CAN"
                  },
                  new Country
                  {
                      Id = 50,
                      Name = "Costa Rica",
                      ISOCode = "CRI"
                  },
                  new Country
                  {
                      Id = 51,
                      Name = "Cuba",
                      ISOCode = "CUB"
                  },
                  new Country
                  {
                      Id = 53,
                      Name = "Curaçao",
                      ISOCode = "CUW"
                  },
                  new Country
                  {
                      Id = 60,
                      Name = "Dominica",
                      ISOCode = "DMA"
                  },
                  new Country
                  {
                      Id = 61,
                      Name = "Dominican Republic",
                      ISOCode = "DOM"
                  },
                  new Country
                  {
                      Id = 78,
                      Name = "Grenada",
                      ISOCode = "GRD"
                  },
                  new Country
                  {
                      Id = 84,
                      Name = "Greenland",
                      ISOCode = "GRL"
                  },
                  new Country
                  {
                      Id = 87,
                      Name = "Guadeloupe",
                      ISOCode = "GLP"
                  },
                  new Country
                  {
                      Id = 91,
                      Name = "Guatemala",
                      ISOCode = "GTM"
                  },
                  new Country
                  {
                      Id = 97,
                      Name = "Honduras",
                      ISOCode = "HND"
                  },
                  new Country
                  {
                      Id = 99,
                      Name = "Haiti",
                      ISOCode = "HTI"
                  },
                  new Country
                  {
                      Id = 112,
                      Name = "Jamaica",
                      ISOCode = "JAM"
                  },
                  new Country
                  {
                      Id = 120,
                      Name = "Saint Kitts and Nevis",
                      ISOCode = "KNA"
                  },
                  new Country
                  {
                      Id = 124,
                      Name = "Cayman Islands",
                      ISOCode = "CYM"
                  },
                  new Country
                  {
                      Id = 128,
                      Name = "Saint Lucia",
                      ISOCode = "LCA"
                  },
                  new Country
                  {
                      Id = 141,
                      Name = "Saint Martin",
                      ISOCode = "MAF"
                  },
                  new Country
                  {
                      Id = 150,
                      Name = "Martinique",
                      ISOCode = "MTQ"
                  },
                  new Country
                  {
                      Id = 152,
                      Name = "Montserrat",
                      ISOCode = "MSR"
                  },
                  new Country
                  {
                      Id = 157,
                      Name = "Mexico",
                      ISOCode = "MEX"
                  },
                  new Country
                  {
                      Id = 165,
                      Name = "Nicaragua",
                      ISOCode = "NIC"
                  },
                  new Country
                  {
                      Id = 173,
                      Name = "Panama",
                      ISOCode = "PAN"
                  },
                  new Country
                  {
                      Id = 180,
                      Name = "Saint Pierre and Miquelon",
                      ISOCode = "SPM"
                  },
                  new Country
                  {
                      Id = 182,
                      Name = "Puerto Rico",
                      ISOCode = "PRI"
                  },
                  new Country
                  {
                      Id = 210,
                      Name = "El Salvador",
                      ISOCode = "SLV"
                  },
                  new Country
                  {
                      Id = 211,
                      Name = "Sint Maarten",
                      ISOCode = "SXM"
                  },
                  new Country
                  {
                      Id = 214,
                      Name = "Turks and Caicos Islands",
                      ISOCode = "TCA"
                  },
                  new Country
                  {
                      Id = 226,
                      Name = "Trinidad and Tobago",
                      ISOCode = "TTO"
                  },
                  new Country
                  {
                      Id = 233,
                      Name = "United States",
                      ISOCode = "USA"
                  },
                  new Country
                  {
                      Id = 237,
                      Name = "Saint Vincent and the Grenadines",
                      ISOCode = "VCT"
                  },
                  new Country
                  {
                      Id = 239,
                      Name = "British Virgin Islands",
                      ISOCode = "VGB"
                  },
                  new Country
                  {
                      Id = 240,
                      Name = "U.S. Virgin Islands",
                      ISOCode = "VIR"
                  }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandfals Resort and Spa",
                    Address = "Toronto",
                    CountryId = 38,
                    Rating = 4.5
                },

                new Hotel
                {
                    Id = 2,
                    Name = "Hotel 2",
                    Address = "Toronto",
                    CountryId = 38,
                    Rating = 4.5
                },

                new Hotel
                {
                    Id = 3,
                    Name = "Hotel 3",
                    Address = "Toronto",
                    CountryId = 38,
                    Rating = 4.5
                }
                );


        }
	}
}

