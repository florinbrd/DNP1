using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data.Entities;
using WebApplication1.Data.Entities.Context;

namespace WebApplication1.Data
{
    public class DbInitializer
    {
        public static void Initialize(CatContext catContext)
        {
            if (catContext.Cats.Any() && catContext.Orders.Any())
            {
                return;
            }

            var cats = new Cat[]
            {
                new Cat
                {
                    id = 1, color = "green", Name = "greenCat", favoriteDish = "fish",
                     Birthdate = new DateTime(2000, 10, 10)
                },
                new Cat
                {
                    id = 2, color = "yellow", Name = "yellowCat", favoriteDish = "dog",
                     Birthdate = new DateTime(2001, 10, 10)
                },
                new Cat
                {
                    id = 4, color = "blue", Name = "blueCat", favoriteDish = "fish",
                     Birthdate = new DateTime(2000, 10, 10)
                },
                new Cat
                {
                    id = 5, color = "red", Name = "redCat", favoriteDish = "fish",
                     Birthdate = new DateTime(2000, 10, 10)
                },
                new Cat
                {
                    id = 6, color = "black", Name = "blackCat", favoriteDish = "fish",
                    Birthdate = new DateTime(2000, 10, 10)
                }
            };

            foreach (var c in cats)
            {
                catContext.Cats.Update(c);
            }
            
           


        }
    }
}