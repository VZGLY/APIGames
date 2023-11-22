using APIGames.Context;
using APIGames.Mappers;
using APIGames.Models;
using APIGames.Models.DTO;
using APIGames.Models.Entities;
using APIGames.Models.Forms;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace APIGames.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GamesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<GamesDTO>> GetAll()
        {
            return Ok(FakeDB.Games.Select(x => x.ToDto()));
        }

        [HttpGet("{id:int}")]
        public ActionResult<Games> GetById(int id)
        {
            Games? game = FakeDB.Games.SingleOrDefault(x => x.Id == id);

            return game is not null ? Ok(game) : NotFound();
        }

        [HttpGet("/search/{name}")]
        public ActionResult<IEnumerable<GamesDTO>> Search(string name)
        {
            IEnumerable<Games> game = FakeDB.Games.Where(x => x.Title.ToLower().Contains(name.ToLower()) || x.Description.ToLower().Contains(name.ToLower()));

            return Ok(game.Select(x => x.ToDto()));
        }

        [HttpPost]
        public ActionResult<Games> Create(CreateGameForm form)
        {
            Games game = form.ToGame();
            game.Id = FakeDB.Games.Max(x => x.Id) + 1;
            game.ReleaseDate = DateTime.Now;

            FakeDB.Games.Add(game);

            return Ok(game);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, UpdateGameForm form)
        {
            Games? game = FakeDB.Games.SingleOrDefault(x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }

            game.PEGI = form.PEGI;
            game.Price = form.Price;
            game.Title = form.Title;
            game.Description = form.Description;

            return NoContent();
        }

        [HttpPatch("{id:int}/price")]
        public IActionResult ChangePassword(int id, ChangePriceForm form) 
        {
            Games? game = FakeDB.Games.SingleOrDefault(x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }

            game.Price = form.Price;

            return NoContent();

        }

        [HttpPatch("{id:int}/pegi")]
        public IActionResult ChangePegi(int id, ChangePegiForm form)
        {
            Games? game = FakeDB.Games.SingleOrDefault(x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }

            game.PEGI = form.Pegi;

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            Games? game = FakeDB.Games.Find(x => x.Id == id);

            if (game is null)
            {
                return NotFound();
            }

            FakeDB.Games.Remove(game);

            return NoContent();
        }

    }
}
