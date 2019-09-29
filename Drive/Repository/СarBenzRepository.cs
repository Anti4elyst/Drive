using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.Model;

namespace Drive.Repository
{
    public class СarBenzRepository
    {
        public List<Car> cars = new List<Car>();

        public СarBenzRepository()
        {
            cars.Add(new Car
            {
                name = "VW Passat",
                cruising_range = "120 км",
                speed = "до 100 км/ч : 16 сек",
                price = "Цена от 100 тысяч рублей",
                klass = "БензКар"
            });
            cars.Add(new Car
            {
                name = "VW Passat",
                cruising_range = "120 км",
                speed = "до 100 км/ч : 16 сек",
                price = "Цена от 100 тысяч рублей",
                klass = "БензКар"
            });
        }

        public Car GetByName(string NAME)
        {
            return cars.Find(car => car.name.Equals(NAME, StringComparison.InvariantCultureIgnoreCase));
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }
    }
}
