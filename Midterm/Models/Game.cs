using System.Collections.Generic;

namespace Midterm
{
    public class Game
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public decimal Price { get; set; } = 0.0m;
    }

    public static class cart
    {
        public static List<Game> CartItems { get; } = new List<Game>();
    }
}
