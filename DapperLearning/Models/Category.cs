using System;

namespace DapperLearning.Models
{
    class Category
    {
        // Need parameterless in Dapper
        public Category() { }
        public Category(Guid id, string? title, string? url, string? summary, int order, string? description, bool featured)
        {
            Id = id;
            Title = title;
            Url = url;
            Summary = summary;
            Order = order;
            Description = description;
            Featured = featured;
        }
        public Category(string? title, string? url, string? summary, int order, string? description, bool featured)
        {
            Title = title;
            Url = url;
            Summary = summary;
            Order = order;
            Description = description;
            Featured = featured;
        }

        // Passamos com os valores corretos, ele pega pelo nome. Pode usar o alias "AS" do SQL se quiser outro nome aqui
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Summary { get; set; }
        public int Order { get; set; }
        public string? Description { get; set; }
        public bool Featured { get; set; }
    }
}