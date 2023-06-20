namespace LinqUsage
{
    class Book
    {
        private string Title { get; set; }
        private int Pages { get; set; }
        private double Price { get; set; }
        public Book()
        {
            Title = "Sample";
            Pages = 0;
            Price = 0.0;
            Console.WriteLine("You created a new sample book.");
        }

        public Book(string title, int pages, double price)
        {
            Title = title;
            Pages = pages;
            Price = price;
            Console.WriteLine("You created a new book:\nTitle: {0}\nPages: {1}\nPrice: {2}", title, pages, price);
        }

        public string GetName() 
        {
            return Title;
        }

        public double GetPrice()
        {
            return Price;
        }



    }
}
