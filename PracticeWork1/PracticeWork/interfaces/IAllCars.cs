using PracticeWork.Models;
using System.Collections.Generic;

namespace PracticeWork.interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car getObjectCar(int carId);
    }
}
