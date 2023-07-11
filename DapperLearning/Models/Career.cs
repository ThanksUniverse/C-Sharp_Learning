using DapperLearning;

namespace DapperLearning.Models
{
    public class Career
    {
        public Career()
        {
            Items = new List<CareerItem>();
        }

        public Guid Id { get; set; }
        public string? Title { get; set; }
        public IList<CareerItem> Items { get; set; }
    }
}