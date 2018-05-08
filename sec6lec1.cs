// Final Lecture
// Lecture Topic: Apply OOP concepts (Class and Objects, Inheritance, Polymorphism, and Encapsulation)

using System;

// namespace unknown
class MainClass
{
  public static void Main (string[] args)
  {

    var car = new Car();
    car.color = "red";
    car.manufacturer = "Toyota";

    var salCar1 = new SaloonCar(2);
    var salCar2 = new SaloonCar(3, "Nissan");
    var salCar3 = new SaloonCar(4, "Ford", "Purple");

    /*
    Print to console to see what each object holds
    Console.WriteLine("Saloon Car 1: " + salCar1.numberOfSeats + " " + salCar1.manufacturer + " " + salCar1.color);
    Console.WriteLine("Saloon Car 2: " + salCar2.numberOfSeats + " " + salCar2.manufacturer + " " + salCar2.color);
    Console.WriteLine("Saloon Car 3: " + salCar3.numberOfSeats + " " + salCar3.manufacturer + " " + salCar3.color);
    */
  }

  public class Car
  {

    public Car () {

    }

    public string color { get; set; }
    public string manufacturer { get; set; }


  }

  // Inherit a class
  public class SaloonCar : Car
  {

    // Write overloaded constructors

    public SaloonCar (int _seats) {
      this.numberOfSeats = _seats;

    }

    public SaloonCar (int _seats, string _manufacturer) {
      this.numberOfSeats = _seats;
      this.manufacturer = _manufacturer;
    }

    public SaloonCar (int _seats, string _manufacturer, string _color) {
      this.numberOfSeats = _seats;
      this.manufacturer = _manufacturer;
      this.color = _color;
    }

    public int numberOfSeats { get; set; }
  }
}