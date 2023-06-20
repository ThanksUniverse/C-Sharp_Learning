using System;

namespace Store
{
    public class Market
    {
        private string[] adjectives = { "Red", "Blue", "Green", "Yellow", "Big", "Small", "Fast", "Slow" };
        private string[] nouns = { "Car", "House", "Tree", "Ball", "Book", "Dog", "Cat", "Chair" };
        public List<Product> MarketProducts = new();

        public void GetProducts()
        {
            if (MarketProducts.Count <= 0)
            {
                Console.WriteLine("The market has no items now, come later.");
                return;
            }
            for (int i = 0; i < MarketProducts.Count; i++)
            {
                Product item = MarketProducts[i];
                Console.WriteLine("[" + i + "]" + "Item Name: " + item.Name + "; Item Price: " + item.Price);
            }
        }

        private void GenerateItems(int amount)
        {
            int randomAmount = amount;
            Random rand = new();
            if (amount == 0)
            {
                randomAmount = rand.Next(20, 100);
            }
            for (int i = 0; i < randomAmount; i++)
            {
                string name = nouns[rand.Next(nouns.Length)] + " " + adjectives[rand.Next(adjectives.Length)];
                int price = rand.Next(1, 100);
                MarketProducts.Add(new Product(name, price));
            }
        }

        public void OpenMarket()
        {
            GenerateItems(5);
        }

        public Market()
        {
            Console.WriteLine("You created a market with the following items.");
            OpenMarket();
        }
    }
}
