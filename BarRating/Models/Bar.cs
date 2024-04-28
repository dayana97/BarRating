namespace BarRating.Models
{
    public class Bar
    {
        public int BarId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; } // Съхраняване на снимки като масив от байтове
    }

}
