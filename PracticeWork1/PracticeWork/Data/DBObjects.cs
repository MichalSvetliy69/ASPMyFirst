using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PracticeWork.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticeWork.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(content => content.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange
                    (
                        new Car { name = "Tesla", ShortDesc = "****", longDesc = "**********", img = "img_1", price = 4500, isFavorite = true, available = true, Category = Categories["Электромобили"] },
                        new Car { name = "BMW", ShortDesc = "**$**", longDesc = "*****$*****", img = "img_2", price = 6500, isFavorite = true, available = true, Category = Categories["Классические автомобили"] }
                    );
            }

            content .SaveChanges();
        }

        private static Dictionary<string, Category> category; 
        public static Dictionary<string,Category> Categories 
        {
            get 
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoruName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {categoruName = "Классические автомобили", desc = "Машины с двигателем внутриннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoruName, el);   
                    }

                }

                return category;
            }
        } 
    }
}
