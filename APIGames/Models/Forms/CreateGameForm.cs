using System.ComponentModel.DataAnnotations;

namespace APIGames.Models.Forms
{
    public class CreateGameForm
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int PEGI { get; set; }

        public double Price { get; set; }
    }
}
