using ApiVersioning.Models;
using System;
using System.Collections.Generic;

namespace ApiVersioning.Serveices
{
    public class OrderDataService
    {
        public static List<OrderViewModel> GetOrders()
        {
            var resultList = new List<OrderViewModel>()
            {
                new OrderViewModel()
                {
                    Id= 1,
                    Price= CalculatePrice(),
                    ProductId= 1,
                    Quantity=4
                },
                new OrderViewModel()
                {
                    Id= 2,
                    Price= CalculatePrice(),
                    ProductId= 45,
                    Quantity=8
                },
                new OrderViewModel()
                {
                    Id= 3,
                    Price= CalculatePrice(),
                    ProductId= 75,
                    Quantity=21
                },

            };
            return resultList;


        }

        private static double CalculatePrice()
        {
            return new Random().Next(1, 1000); //Get price from Db
        }
    }
}
