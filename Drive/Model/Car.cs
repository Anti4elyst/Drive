using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive.Model
{
    public class Car
    {
        public string name { get; set; }
        public string speed { get; set; }
        public string cruising_range { get; set; }
        public string price { get; set; }
        public string klass { get; set; }

        public void GetCharacteristic()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Разгон: " + speed);
            Console.WriteLine("Запас хода: " + cruising_range);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Вид двигателя: " + klass);
        }
    }
}
