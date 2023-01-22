using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace versta24.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа #")]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Город отправителя")]
        public string? DepartureCity { get; set; }
        
        [Required]
        [StringLength(90, MinimumLength = 4)]
        [Display(Name = "Адрес отправителя")]
        public string? DepartureAddress { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Город получателя")]
        public string? RecipentCity { get; set; }
        
        [Display(Name = "Адрес получателя")]
        [Required]
        [StringLength(90, MinimumLength = 4)]
        public string? RecipentAddress { get; set; }

        [Required]
        
        [Display(Name = "Вес груза, кг")]
        public double Weight { get; set; }

        [Required]
        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime CollectionDate { get; set; }
    }
}
