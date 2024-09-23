using System;

class Program {
  public static void Main (string[] args) {


    Console.WriteLine("What is the minimum sustained wind speed? : ");
      double windSpeed;
      double.TryParse(Console.ReadLine(), out windSpeed);

    
    if (windSpeed < 74) 
    {
        Console.WriteLine("Not a Hurricane");
    }
    else if (windSpeed >= 74 && windSpeed < 96) 
    {
        Console.WriteLine("Category One Hurricane");
    }
    else if (windSpeed >= 96 && windSpeed < 111)
    {
       Console.WriteLine("Category Two Hurricane");
    }
    else if (windSpeed >= 111 && windSpeed < 130)
      {
        Console.WriteLine("Category Three Hurricane");
      }
    else if (windSpeed >= 130 && windSpeed < 157)
      {
        Console.WriteLine("Category Four Hurricane");
      }
    else if (windSpeed >= 157)
    {
      Console.WriteLine("Category Five Hurricane");
    }
    
  
  }
}