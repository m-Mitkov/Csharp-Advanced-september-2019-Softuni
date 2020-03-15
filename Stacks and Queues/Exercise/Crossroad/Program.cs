using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace crossRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCarsCross = 0;

            while (true)
            {
                string comand = Console.ReadLine();


                if (comand == "END")
                {
                    break;
                }

                if (comand != "green")
                {
                    cars.Enqueue(comand);
                }

                else
                {
                    int currentGreenLight = greenLightDuration;
                    int currentFreeWindow = freeWindow;

                    string currentCar = string.Empty;
                    int carLeftOver = -1;

                    while (currentGreenLight > 0)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        currentCar = cars.Dequeue();
                        totalCarsCross++;

                        int carLenght = currentCar.Length;

                        for (int i = 0; i < carLenght; i++)
                        {
                            currentGreenLight--;

                            if (currentGreenLight == 0)
                            {
                                carLeftOver = carLenght - (i + 1);
                                break;
                            }
                        }
                    }

                    if (carLeftOver != -1 || cars.Count > 0)
                    {
                        while (currentFreeWindow > 0)
                        {
                            carLeftOver--;

                            if (carLeftOver == 0)
                            {
                                break;
                            }

                            currentFreeWindow--;
                        }
                    }

                    if (carLeftOver > 0)
                    {
                        Console.WriteLine("A crash happened!" + Environment.NewLine
                            + $"{currentCar} was hit at {currentCar[currentCar.Length - carLeftOver]}.");
                        return;
                    }
                }
            }

            Console.WriteLine($"Everyone is safe." + Environment.NewLine +
                        $"{totalCarsCross} total cars passed the crossroads.");
        }
    }
}