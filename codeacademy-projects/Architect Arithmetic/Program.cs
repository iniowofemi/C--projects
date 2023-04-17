using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static double Rect(double width, double length)
    {
      double areaRect;
      return (areaRect = width * length);
    }

    public static double Circ(double radius)
    {
      double areaCirc;
      return areaCirc = Math.PI*Math.Pow(radius, 2);
    }

    public static double Tri(double bottom, double height)
    {
      double areaTri;
      return areaTri = 0.5 * bottom * height;
    }

    public static void CalculateTotalCostTeotihuacan()
    {
      double rectArea = Rect(1500,2500);
      double circArea = Circ(375);
      double triArea = Tri(750,500);

      double totalArea = rectArea + circArea + triArea;
      double totalCost = totalArea * 180;

      Console.WriteLine($"The cost of the floor plan is {Math.Round(totalCost,2)} Mexican pesos");
    }

    public static void CalculateTotalCostTajMahal()
    {
      double rectArea = Rect(90.5,90.5);
      double triArea = Tri(24,24);

      double totalArea = rectArea -(4*triArea);

      double totalCost = totalArea * 180;

      Console.WriteLine($"The cost of the floor plan is {Math.Round(totalCost,2)} Mexican pesos");
    }

    public static void CalculateTotalCostGreatMosqueOfMecca()
    {
      double rectArea1 = Rect(180,106);
      double rectArea2 = Rect(284,264);
      double triArea = Tri(264,84);
      
      double totalArea = rectArea1 + rectArea2 - triArea;

      double totalCost = totalArea * 180;

      Console.WriteLine($"The cost of the floor plan is {Math.Round(totalCost,2)} Mexican pesos");
    }

    public static void Main(string[] args)
    {
      Console.WriteLine("Which monument would you like to calculate the cost for? \n\n1. Teotihuacan\n2. Taj Mahal\n3. Great Mosque of Mecca\n");
      
      string choice = Console.ReadLine();
      switch (choice)
      {
        case "1":
          CalculateTotalCostTeotihuacan();
          break;
        case "2":
          CalculateTotalCostTajMahal();
          break;
        case "3":
          CalculateTotalCostGreatMosqueOfMecca();
          break;
        default:
          Console.WriteLine("That's an invalid option. Sorry!");
          break;
      }
    }
  }
}

