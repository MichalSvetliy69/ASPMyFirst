using PracticeWork.Models;
using System.Collections.Generic;

namespace PracticeWork.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
