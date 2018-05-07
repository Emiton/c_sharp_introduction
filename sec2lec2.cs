// An introduction to object initialization and constructors

using System;

// namespace Bulldozer
class MainClass {
  public static void Main (string[] args) {

    var dozer = new BullDozer("Yellow", "Mini");
    var dozer2 = new BullDozer("Red", "Large");
    Console.WriteLine ("Bulldozer 1 is " + dozer.color);
    Console.WriteLine ("Bulldozer 2 is " + dozer2.color);
  }

  public class BullDozer {


    public BullDozer (string _color, string _size) {
      this.color = _color;
      this.size = _size;

    }
    public string color { get; set; }
    public string size { get; set; }
  }
}