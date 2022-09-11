using System;

namespace Logvinov_153505_Lab1
{
    internal class Program
    {
        public static MyCustomCollection<Customer> customers = new MyCustomCollection<Customer>();

        public static void add_client()
        {
            while (true)
            {
                //цикл для добавления клиентов 
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
                Customer customer = new Customer(client);
                while (true)
                {
                    // цикл для добавления услуг клиентам 

                    int rate_number = Int32.Parse(Console.ReadLine());
                    if (rate_number <= Rates.Count && rate_number != 0 )
                    {
                        customer.Add(rate_number - 1);
                    }
                    else
                    {
                        break;
                    }

                   
                }
                customers.Add(customer);

                Console.Write("If you wanna add one customer yet , please write 1 ," +
                              "else write another value : ");
                int for_work = Int32.Parse(Console.ReadLine());
                if (for_work != 1)
                {
                    break;
                }
            }
        }

        public static void add_rates()
        {
            while (true)
            {
                //заполнение класса услуги 
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
        }


        public static void Main(string[] args)
        {
            //создание коллекции клиентов 
            Console.WriteLine("Please , add your rate ");
            Console.Write("Name of rate : ");
            string name = Console.ReadLine();
            Console.Write("Rates price : ");
            int price = Int32.Parse(Console.ReadLine());
            Rates.Add(name, price);
            add_rates();
            /*while (true)
            {
                //заполнение класса услуги 
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
            }*/
            add_client();
            /*while (true)
            {
                //цикл для добавления клиентов 
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
                Customer customer = new Customer(client);
                while (true)
                {
                    // цикл для добавления услуг клиентам 

                    int rate_number = Int32.Parse(Console.ReadLine());
                    if (rate_number <= Rates.Count)
                    {
                        customer.Add(rate_number - 1);
                    }
                    else
                    {
                        break;
                    }

                    customers.Add(customer);
                }

                Console.Write("If you wanna add one customer yet , please write 1 ," +
                              "else write another value : ");
                int for_work = Int32.Parse(Console.ReadLine());
                if (for_work != 1)
                {
                    break;
                }
            }*/

            while (true)
            {
                Console.WriteLine("Choose your option : ");
                Console.WriteLine("1) Add customer");
                Console.WriteLine("2) Add new type of rate");
                Console.WriteLine("3) Show results");
                Console.WriteLine("0) Leave this step");
                int for_output = Int32.Parse(Console.ReadLine());
                if (for_output == 1)
                {
                    add_client();
                }
                else if (for_output == 2)
                {
                    add_rates();
                }
                else if (for_output == 3)
                {
                    Console.WriteLine("Your customers : ");
                    for (int i = 0; i < customers.Count; i++)
                    {
                        Console.WriteLine((i + 1).ToString() + " " + customers[i].name);
                    }

                    Console.Write("Select , which one you wanna check : ");
                    int cust = Int32.Parse(Console.ReadLine());
                    if (cust <= customers.Count)
                    {
                        Console.WriteLine($"{customers[cust - 1].name}");
                        for (int i = 0; i < customers[cust - 1].rates.Count; i++)
                        {
                            Console.WriteLine(customers[cust - 1].rates[i]);
                        }
                        Console.WriteLine($"Amount of money : {customers[cust- 1].money} $");
                    }
                    else
                    {
                        Console.WriteLine("Please , try yet!");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}