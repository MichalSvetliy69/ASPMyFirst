
using PracticeWork.interfaces;
using PracticeWork.Models;
using System.Collections.Generic;

namespace PracticeWork.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoruName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoruName = "Классические автомобили", desc = "Машины с двигателем внутриннего сгорания"},
                };
            }
        }

       
    }
}
