namespace Store
{
    public class Customer
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        private List<Product> Items = new();

        public Customer(string name, int balance)
        {
            Name = name;
            Balance = balance;
            Console.WriteLine("--------------\nYou created a new customer:\nName: {0}\nBalance: {1}\n--------------", Name, Balance);
        }

        public int GetItems()
        {

            if (Items.Count == 0)
            {
                Console.WriteLine("You doesnt have any items.");
                return 0;
            }
            for(int i = 0; i < Items.Count; i ++)
            {
                Product it = Items[i];
                Console.WriteLine("[{0}] Item Name: {1}; Item Price: {2}", i, it.Name, it.Price);
            }
            return Items.Count;
        }

        public void BuyProduct(int index, Market market)
        {
            if (market is null)
            {
                Console.WriteLine("Check if this market exists.");
                return;
            }
            if (market.MarketProducts.Count < index)
            {
                Console.WriteLine("We doesnt have this item.");
                return;
            }
            Product it = market.MarketProducts[index];
            if (it.Price > Balance)
            {
                Console.WriteLine("You dont have enough money to buy this item.");
                return;
            }

            Console.WriteLine("You bought {0} for {1}", it.Name, it.Price);
            Items.Add(it);
            market.MarketProducts.RemoveAt(index);
            Balance-=it.Price;
        }

        public void SellProduct(int index, Market market)
        {
            if (Items.Count < index)
            {
                Console.WriteLine("You doesnt have any item in this pocket.");
                return;
            }
            Product it = Items[index];
            market.MarketProducts.Add(it);
            Console.WriteLine("You sould {0} for {1}", it.Name, it.Price);
            Items.RemoveAt(index);
            Balance += it.Price;
        }

        public void GetInformation()
        {
            Console.WriteLine("--{0}--\nBalance: {1}", Name, Balance);
            GetItems();
        }
    }
}