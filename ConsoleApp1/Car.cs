using System;

class Car
{
    //test 11.03
    // Pola prywatne (enkapsulacja)
    private string _brand;
    private string _model;
    private int _doorCount;
    private double _engineVolume;
    private double _avgConsump;

    // Pole statyczne do przechowywania liczby utworzonych obiektów
    private static int _carCount = 0;

    // Właściwości (gettery i settery)
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int DoorCount
    {
        get { return _doorCount; }
        set { _doorCount = value; }
    }

    public double EngineVolume
    {
        get { return _engineVolume; }
        set { _engineVolume = value; }
    }

    public double AvgConsump
    {
        get { return _avgConsump; }
        set { _avgConsump = value; }
    }

    // Konstruktor domyślny
    public Car()
    {
        _brand = "Unknown";
        _model = "Unknown";
        _doorCount = 0;
        _engineVolume = 0.0;
        _avgConsump = 0.0;
        _carCount++; // Zwiększ licznik obiektów
    }

    // Konstruktor parametryczny
    public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _carCount++; // Zwiększ licznik obiektów
    }

    // Metoda obliczająca spalanie na danej trasie (litry)
    public double CalculateConsump(double distance)
    {
        return (distance * _avgConsump) / 100.0;
    }

    // Metoda obliczająca koszt paliwa na danej trasie
    public double CalculateCost(double distance, double fuelPrice)
    {
        return CalculateConsump(distance) * fuelPrice;
    }

    // Metoda wyświetlająca informacje o samochodzie
    public void DisplayInfo()
    {
        Console.WriteLine("Informacje o samochodzie:");
        Console.WriteLine($"Marka: {_brand}");
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Liczba drzwi: {_doorCount}");
        Console.WriteLine($"Pojemność silnika: {_engineVolume} L");
        Console.WriteLine($"Średnie spalanie: {_avgConsump} L/100km");
    }

    // Metoda statyczna wyświetlająca liczbę utworzonych obiektów
    public static void DisplayCarCount()
    {
        Console.WriteLine($"Liczba utworzonych samochodów: {_carCount}");
    }
}


class Garage
{
    public string Address { get; set; }
    public int Capacity { get; set; }
    private int carsCount;
    private Car[] cars;

    public Garage(string address, int capacity)
    {
        Address = address;
        Capacity = capacity;
        cars = new Car[capacity];
        carsCount = 0;
    }

    public void AddCar(Car car)
    {
        if (carsCount < Capacity)
        {
            cars[carsCount] = car;
            carsCount++;
            Console.WriteLine("Samochód dodany do garażu.");
        }
        else
        {
            Console.WriteLine("Garaż jest pełny!");//komentarz
        }
    }

    public void RemoveCar()
    {
        if (carsCount > 0)
        {
            carsCount--;
            cars[carsCount] = null;
            Console.WriteLine("Ostatni samochód został usunięty z garażu.");
        }
        else
        {
            Console.WriteLine("Garaż jest pusty!");
        }
    }

    public void DisplayGarageInfo()
    {
        Console.WriteLine($"Garaż na {Address}, pojemność: {Capacity}, liczba samochodów: {carsCount}");
        for (int i = 0; i < carsCount; i++)
        {
            cars[i].DisplayInfo();
        }
    }
}
