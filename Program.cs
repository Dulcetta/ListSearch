using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listTal = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };
            List<int> zeroorless = listTal.Where(number => number <= 0).ToList();
            List<int> equalseven = listTal.Where(number => number == 7).ToList();
            List<int> equalfour = listTal.Where(number => number == 4).ToList();
            Udskrivlist(equalfour);

            Car c1 = new Car() { Id = 1, Model = "Rio", Brand = "Kia", Year = 2006, Price = 250000, Color = "Red" };
            Car c2 = new Car() { Id = 2, Model = "Rio", Brand = "Kia", Year = 2006, Price = 265000, Color = "Black" };
            Car c3 = new Car() { Id = 3, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 265000, Color = "Black" };
            Car c4 = new Car() { Id = 4, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 365000, Color = "Yellow" };
            Car c5 = new Car() { Id = 5, Model = "S40", Brand = "Volvo", Year = 2018, Price = 665000, Color = "White" };
            Car c6 = new Car() { Id = 6, Model = "S65", Brand = "Volvo", Year = 2018, Price = 600000, Color = "White" };
            Car c7 = new Car() { Id = 7, Model = "Gorm", Brand = "Ferrari", Year = 2000, Price = 466500, Color = "White" };
            Car c8 = new Car() { Id = 8, Model = "Gorm", Brand = "Ferrari", Year = 2018, Price = 466500, Color = "White" };

            Console.WriteLine();

            List<Car> listcar = new List<Car>() { c1, c2, c3, c4, c5, c6, c7, c8 };

            List<Car> Rio = listcar.Where(car => car.Model == "Rio").ToList();
            List<Car> Ferrari = listcar.Where(car => car.Brand == "Ferrari").ToList();
            List<Car> yearcar = listcar.Where(car => car.Year >= 2010).ToList();
            List<Car> White = listcar.Where(car => car.Color == "White").ToList();
            List<Car> idCar = listcar.Where(car => car.Id == 8).ToList();

            Udskrivlist(Rio);
            Udskrivlist(Ferrari);
            Udskrivlist(yearcar);
            Udskrivlist(White);
            Udskrivlist(idCar);



        }
        private static void Udskrivlist(List<int> listResultat0)
        {
            foreach (int m in listResultat0)
            {
                Console.WriteLine(m);
            }
        }
        static void Udskrivlist(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(Cartabels(car));
            }
            Console.WriteLine();
        }

        static void Udskrivlist(Car car)
        {
            Console.WriteLine(Cartabels(car));
            Console.WriteLine();
        }

        static string Cartabels(Car car)
        {
            return $"ID: {car.Id} | {car.Brand} {car.Model} ({car.Year}) | Price: {car.Price:C} | Color: {car.Color}";
        }
    }
}
