using System;


class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Corolla", 4, 1.8, 6.5);
        Car car2 = new Car("Ford", "Focus", 4, 2.0, 7.2);

        Garage garage = new Garage("ul. Miodowa 15", 2);
        garage.AddCar(car1);
        garage.AddCar(car2);
        garage.DisplayGarageInfo();

        garage.RemoveCar();
        garage.DisplayGarageInfo();
    }
}