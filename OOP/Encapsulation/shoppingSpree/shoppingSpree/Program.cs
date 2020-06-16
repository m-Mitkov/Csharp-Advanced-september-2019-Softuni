using System;
using System.Collections.Generic;
using System.Linq;

namespace shoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            GetPeople(people);

            List<Product> products = new List<Product>();
            GetProducts(products);

            while (true)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                if (comand[0] == "END")
                {
                    break;
                }

                string personName = comand[0];
                string productName = comand[1];

                var buyer = people.FirstOrDefault(x => x.Name == personName);
                var currentProduct = products.FirstOrDefault(x => x.Name == productName);

                if (buyer != null && currentProduct != null)
                {
                    if (buyer.BuyProduct(currentProduct) == false)
                    {
                        Console.WriteLine($"{buyer.Name} can't afford {currentProduct.Name}");
                    }

                    else
                    {
                        Console.WriteLine($"{buyer.Name} bought {currentProduct.Name}");
                    }
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public static void GetProducts(List<Product> products)
        {
            string[] inputProducts = Console.ReadLine()
    .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in inputProducts)
            {
                string[] productArgs = item
                    .Split("=");

                string productInput = productArgs[0];
                decimal price = decimal.Parse(productArgs[1]);

                try
                {

                    Product product = new Product(productInput, price);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
        public static void GetPeople(List<Person> people)
        {
            var inputPeople = Console.ReadLine()
     .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in inputPeople)
            {
                string[] inputArgs = item
                    .Split("=");

                string name = inputArgs[0];
                decimal money = decimal.Parse(inputArgs[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
    }
}
