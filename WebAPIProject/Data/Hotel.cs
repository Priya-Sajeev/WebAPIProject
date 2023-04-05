﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIProject.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string  Address { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }


    }
}
