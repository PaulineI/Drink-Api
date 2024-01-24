namespace drink_api.Models
{
    public class Drinks
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Ingredients { get; set; }

        public string? Instructions { get; set; }
    }
}
