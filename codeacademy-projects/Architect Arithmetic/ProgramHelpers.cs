using System;

namespace ArchitectArithmetic
{
    internal static class ProgramHelpers
    {

        public static void CalculateTotalCostTeotihuacan()
        {
            double rectArea = Rect(1500, 2500);
            double circArea = Circ(375);
            double triArea = Tri(750, 500);

            double totalArea = rectArea + circArea + triArea;
            double totalCost = totalArea * 180;

            Console.WriteLine($"The cost of the floor plan is {Math.Round(totalCost, 2)} Mexican pesos");
        }
    }
}