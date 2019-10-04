using System;

class FirstLetterChecker
{
  static void Main()
  {
    // Example arrays
    string[] fruits = { "apples", "bananas", "oranges", "grapes" };
    int[] primeNumbers = { 2, 3, 5, 7, 11 };

    // Dictionary & example calls
    Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };
    // > myDictionary
    // { {"A", "apple"}, {"B", "bear"} }
    //
    // > myDictionary["A"]
    // "apple"
    //
    // > myDictionary["B"]
    // "bear"

    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    if (userName.StartsWith("Z"))
    {
      Console.WriteLine("Your name starts with a Z!");
    }
    else
    {
      Console.WriteLine("Your name doesn't start with a Z :(");
    }
  }
}
