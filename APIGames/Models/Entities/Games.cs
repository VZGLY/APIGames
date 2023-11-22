namespace APIGames.Models.Entities
{
    public class Games
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int PEGI { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }


    }
}
