
using System;

// Определение базового класса "Машина"
public class Car
{
    protected string brand; // Марка
    protected int cylinders; // Число цилиндров
    protected int power; // Мощность

    // Конструктор по умолчанию
    public Car()
    {
        brand = "Unknown";
        cylinders = 4;
        power = 100;
    }

    // Конструктор с параметрами
    public Car(string brand, int cylinders, int power)
    {
        this.brand = brand;
        this.cylinders = cylinders;
        this.power = power;
    }

    // Деструктор (finalizer)
    ~Car()
    {
        Console.WriteLine("Car object destroyed.");
    }

    // Функция печати
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}, Cylinders: {cylinders}, Power: {power}hp");
    }

    // Функция переназначения марки
    public void RedefineBrand(string newBrand)
    {
        brand = newBrand;
    }
}

// Производный класс "Грузовик"
public class Truck : Car
{
    private double carryingCapacity; // Грузоподъемность кузова

    // Конструктор по умолчанию
    public Truck() : base()
    {
        carryingCapacity = 1000;
    }

    // Конструктор с разным числом параметров
    public Truck(string brand, int cylinders, int power, double carryingCapacity) : base(brand, cylinders, power)
    {
        this.carryingCapacity = carryingCapacity;
    }

    // Деструктор (finalizer)
    ~Truck()
    {
        Console.WriteLine("Truck object destroyed.");
    }

    // Функция печати
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Carrying Capacity: {carryingCapacity}kg");
    }

    // Функция переназначения грузоподъемности
    public void RedefineCarryingCapacity(double newCapacity)
    {
        carryingCapacity = newCapacity;
    }
}