namespace DapperLearning.Models
{
    public class CareerItem
    {
        public CareerItem() { }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Course? Course { get; set; }
    }
}