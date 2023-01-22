using System;
using System.ComponentModel.DataAnnotations;

namespace versta24.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? DepartureCity { get; set; }
        public string? DepartureAddress { get; set; }
        public string? RecipentCity { get; set; }
        public string? RecipentAddress { get; set; }
        public double Weight { get; set; }
        [DataType(DataType.Date)]
        public DateTime CollectionDate { get; set; }
    }
}
