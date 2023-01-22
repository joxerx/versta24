using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace versta24.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа #")]
        public int Id { get; set; }    
        [Display(Name = "Город отправителя")]
        public string? DepartureCity { get; set; }
        [Display(Name = "Адрес отправителя")]
        public string? DepartureAddress { get; set; }
        [Display(Name = "Город получателя")]
        public string? RecipentCity { get; set; }
        [Display(Name = "Адрес получателя")]
        public string? RecipentAddress { get; set; }
        [Display(Name = "Вес груза")]
        public double Weight { get; set; }
        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime CollectionDate { get; set; }
    }
}
