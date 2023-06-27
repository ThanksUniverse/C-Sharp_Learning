namespace Paymentsx
{
    public partial class Payment
    {
        public string Text { get; set; }
        public Payment(string text)
        {
            Console.WriteLine(text);
            Text = text;
        }
    }
}