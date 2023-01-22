using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using versta24.Data;
using System;
using System.Linq;

namespace versta24.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new versta24Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<versta24Context>>()))
        {
            // Look for any movies.
            if (context.Order.Any())
            {
                return;   // DB has been seeded
            }
            context.Order.AddRange(
                new Order
                {
                    DepartureCity = "Москва",
                    DepartureAddress = "Земляной вал, д. 34",
                    RecipentCity = "Тамбов",
                    RecipentAddress = "Шпагина, д. 33",
                    Weight= 10.50,
                    CollectionDate = DateTime.Now.AddDays(-3),
                },
                new Order
                {
                    DepartureCity = "Санкт-Петербург",
                    DepartureAddress = "Введенская, д. 10",
                    RecipentCity = "Москва",
                    RecipentAddress = "Ленинский проспект, д. 10",
                    Weight = 31.94,
                    CollectionDate = DateTime.Now.AddDays(-2),
                },
                new Order
                {
                    DepartureCity = "Нижний Новгород",
                    DepartureAddress = "Набережная, д. 3",
                    RecipentCity = "Красноярск",
                    RecipentAddress = "Лобачевского, д. 73",
                    Weight = 13.32,
                    CollectionDate = DateTime.Now.AddDays(-1),
                },
                new Order
                {
                    DepartureCity = "Москва",
                    DepartureAddress = "Ленина, д. 11",
                    RecipentCity = "Санкт-Петербург",
                    RecipentAddress = "Профессора Попова, д. 5",
                    Weight = 135.93,
                    CollectionDate = DateTime.Now.AddDays(3),
                }
            );
            context.SaveChanges();
        }
    }
}
