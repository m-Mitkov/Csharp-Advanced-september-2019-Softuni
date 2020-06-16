using System;


namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var pizzaParameters = Console.ReadLine()
                    .Split();

                var pizzaName = pizzaParameters[1];

                var doughParameters = Console.ReadLine()
                    .Split();
                var flourType = doughParameters[1];
                var bakingTechnique = doughParameters[2];
                var grams = double.Parse(doughParameters[3]);

                var dough = new Dough(flourType, bakingTechnique, grams);
                var pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    var inputLine = Console.ReadLine();
                    if (inputLine == "END")
                    {
                        break;
                    }

                    var toppingParameters = inputLine
                        .Split();
                    var toppingName = toppingParameters[1];
                    var toppingGrams = double.Parse(toppingParameters[2]);

                    var topping = new Topping(toppingName, toppingGrams);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():F2} Calories.");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
