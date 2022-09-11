namespace Logvinov_153505_Lab1
{
    internal class Rates
    {
        private Rates()
        {
        }

        public static void Add(string name, int price)
        {
            rates_name.Add(name);
            cost.Add(price);
            count++; 
            
        }

        public static int Count
        {
            get => count;
        }

        private static int count = 0; 
        public static MyCustomCollection<string> rates_name = new MyCustomCollection<string>();
        public static MyCustomCollection<int> cost = new MyCustomCollection<int>();
    }

    public class Customer
    {
        public Customer(string name)
        {
            rates = new MyCustomCollection<string>();
            this.name = name;
            money = 0; 

        }

        public void Add(int i)
        {
            rates.Add(Rates.rates_name[i]);
            money += Rates.cost[i];
        }
        
        public string name;
        public int money;
        public MyCustomCollection<string> rates;

    }
}