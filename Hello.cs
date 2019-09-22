// Our directives: this tells the code what it needs to function
using System; // Needed for Console

class Program {
  // Entry Point
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    int yourNumber = int.Parse(Console.ReadLine()) * 2;
    Console.WriteLine("I doubled your number to " + yourNumber);
  }
}
