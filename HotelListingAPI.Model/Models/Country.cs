﻿namespace HotelListingAPI.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ISOCode { get; set; }

        public virtual  IList<Hotel>? Hotels { get; set; }
    }
}