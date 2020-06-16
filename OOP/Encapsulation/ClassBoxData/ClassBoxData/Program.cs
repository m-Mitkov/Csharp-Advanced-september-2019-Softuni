using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea(box):F2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea(box):F2}");
                Console.WriteLine($"Volume - {box.GetVolume(box):F2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);

            }
        }
    }
}
