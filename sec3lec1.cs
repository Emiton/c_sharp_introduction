// An introduction to Inheritance. Create parent class and child classes

using System;

// namespace Bulldozer
class MainClass
{
  public static void Main (string[] args) {

    var man = new Man();
    var kart = new Kart();
    var alien = new Alien();



  }

  public class GeneralObject
  {
    public GeneralObject () {

    }

    public bool move { get; set; }
    public string color { get; set; }

  }

  public class Man : GeneralObject
  {

    public Man () {

    }
    public string name { get; set; }
  }



  public class Kart : GeneralObject
  {

    public Kart() {

    }

    public string manufacturer { get; set; }

  }

    public class Alien : GeneralObject
    {

    public Alien() {

    }

    public string planet { get; set; }

  }
}