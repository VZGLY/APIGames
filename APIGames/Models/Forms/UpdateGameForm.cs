namespace APIGames.Models.Forms
{
    public class UpdateGameForm
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int PEGI { get; set; }

        public double Price { get; set; }
    }
}
