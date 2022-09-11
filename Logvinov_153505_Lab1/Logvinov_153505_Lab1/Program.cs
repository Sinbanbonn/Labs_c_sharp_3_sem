using System;

namespace Logvinov_153505_Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyCustomCollection<Customer> customers = new MyCustomCollection<Customer>();
            //создание коллекции клиентов 
            Console.WriteLine("Please , add your rate ");
            Console.Write("Name of rate : ");
            string name = Console.ReadLine();
            Console.Write("Rates price : ");
            int price = Int32.Parse(Console.ReadLine());
            Rates.Add(name, price);
            bool for_rates = true;
            while (true)
            { //заполнение класса услуги 
                Console.Write("if you wanna add one rate yet - write 1 , else write other number : ");
                int action = Int32.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Console.Write("Name of rate : ");
                    string new_name = Console.ReadLine();
                    Console.Write("Rates price : ");
                    int new_price = Int32.Parse(Console.ReadLine());
                    Rates.Add(new_name, new_price);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have a {Rates.Count} type(s) of rates");
                    break;
                }
            }

            while (true)
            { //цикл для добавления клиентов 
                Console.Write("Add name of your client : ");
                string client = Console.ReadLine();
                Console.WriteLine("Add consumed rates from list : ");
                for (int i = 0; i < Rates.Count; i++)
                {
                    Console.Write((i + 1).ToString() + ") ");
                    Console.WriteLine(Rates.rates_name[i] + "  " + Rates.cost[i].ToString() + " $");
                }
                Console.WriteLine("Please write number of rate or " +
                                  "another value to leave this step : ");
                customers.Add(new Customer(client));
                while (true)
                { // цикл для добавления услуг клиентам 
                    int rate_number = Int32.Parse(Console.ReadLine());
                    if (rate_number <= Rates.Count)
                    {
                        
                    }
                }
            }
        }
    }
}