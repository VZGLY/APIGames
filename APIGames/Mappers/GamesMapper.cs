using APIGames.Models.DTO;
using APIGames.Models.Entities;
using APIGames.Models.Forms;

namespace APIGames.Mappers
{
    public static class GamesMapper
    {
        public static GamesDTO ToDto(this Games game)
        {
            return new GamesDTO
            {
                Id = game.Id,
                Title = game.Title,
                Description = game.Description

            };
        }

        public static Games ToGame(this CreateGameForm form)
        {
            return new Games
            {
                Id = 0,
                Title = form.Title,
                Description = form.Description,
                PEGI = form.PEGI,
                Price = form.Price,
                ReleaseDate = DateTime.Now
            };
        }
    }
}
