using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.Model;

namespace Drive.Repository
{
    public class CarAutoRepository
    {
        public List<Car> cars = new List<Car>();

        public CarAutoRepository()
        {
            cars.Add(new Car
            {
                name = "Tesla X",
                cruising_range = "500 км",
                speed = "до 100 км/ч : 2.9 сек",
                price = "от 9 миллионов рублей",
                klass = "ЭлектроКар"
            });
            cars.Add(new Car
            {
                name = "Tesla X",
                cruising_range = "500 км",
                speed = "до 100 км/ч : 2.9 сек",
                price = "от 9 миллионов",
                klass = "ЭлектроКар"
            });
        }

        public Car GetByName(string NAME1)
        {
            return cars.Find(car => car.name.Equals(NAME1, StringComparison.InvariantCultureIgnoreCase));
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }
    }
}
