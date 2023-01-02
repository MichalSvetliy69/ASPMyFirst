using PracticeWork.interfaces;
using PracticeWork.Models;
using System.Collections.Generic;

namespace PracticeWork.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
