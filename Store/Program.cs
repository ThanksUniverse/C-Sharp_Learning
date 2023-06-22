using System; // We declare that we will be using the library System
namespace Store // Then we declare our namespace so we can connect to other files
{
    public class Store // Create our class that will be in this file
    {
        public static void Main() // The main method that will be executed
        {
            string notIndex = "We couldnt find this index in the table.";
            Random rand = new();
            int money = rand.Next(1, 100);
            Customer you = new("Pedro", money);

            Market market = new();
            market.GetProducts();

            string? answer = Console.ReadLine();
            while (answer != "exit")
            {
                switch (answer)
                {
                    case ("buy"):
                        market.GetProducts();
                        Console.Write("Which index of product you want ?\n");
                        string buyProduct = Console.ReadLine();
                        int bProduct;
                        if (int.TryParse(buyProduct, out bProduct))
                            you.BuyProduct(bProduct, market);
                        else
                            Console.WriteLine(notIndex);
                        break;
                    case ("sell"):
                        if (you.GetItems() == 0)
                            break;
                        Console.WriteLine("Which index of product you want to sell ?\n");
                        string sellProduct = Console.ReadLine();
                        int sProduct;
                        if (int.TryParse(sellProduct, out sProduct))
                            you.SellProduct(sProduct, market);
                        else
                            Console.WriteLine(notIndex);
                        break;
                    case ("market"):
                        market.GetProducts();
                        break;
                    case ("me"):
                        you.GetInformation();
                        break;
                    case ("commands"):
                        Console.WriteLine("Commands:\nBuy\nSell\nMarket\nCommands");
                        break;
                    default:
                        you.GetItems();
                        break;

                }
                answer = Console.ReadLine();
            }
        }
    }
}