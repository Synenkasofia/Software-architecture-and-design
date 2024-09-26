using System;
using System.Collections.Generic;

// Легковаговик
class Car
{
    public string Model { get; }

    public Car(string model)
    {
        Model = model;
    }

    public void Display(string color)
    {
        Console.WriteLine($"Модель: {Model}, Колір: {color}");
    }
}

// Фабрика легковаговиків
class CarFactory
{
    private Dictionary<string, Car> cars = new Dictionary<string, Car>();

    public Car GetCar(string model)
    {
        if (!cars.ContainsKey(model))
        {
            cars[model] = new Car(model);
        }
        return cars[model];
    }
}

// Використання
class Program
{
    static void Main(string[] args)
    {
        CarFactory factory = new CarFactory();

        // Отримуємо автомобілі
        Car car1 = factory.GetCar("Toyota");
        Car car2 = factory.GetCar("Honda");
        Car car3 = factory.GetCar("Toyota");

        // Виводимо різні кольори для однієї моделі
        car1.Display("Червоний");
        car2.Display("Синій");
        car3.Display("Зелений");
    }
}
