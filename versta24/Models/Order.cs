using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace versta24.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа #")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Город отправителя")]
        public string? DepartureCity { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(90, MinimumLength = 4)]
        [Display(Name = "Адрес отправителя")]
        public string? DepartureAddress { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Город получателя")]
        public string? RecipentCity { get; set; }
        
        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage ="Обязательное поле")]
        [StringLength(90, MinimumLength = 4)]
        public string? RecipentAddress { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Range(typeof(double), "0,1", "10000,0", ErrorMessage = "Значение поля может принимать значения от 0,1 до 10000,0. Запятая в качестве разделителя")]
        [Display(Name = "Вес груза, кг")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime CollectionDate { get; set; }
    }
}
