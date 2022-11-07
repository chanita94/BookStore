namespace book.web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateOnDateTime { get; set; } = DateTime.Now;
    }
}
