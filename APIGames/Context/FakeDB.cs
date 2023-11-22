using APIGames.Models.Entities;
using System;

namespace APIGames.Context
{
    public static class FakeDB
    {
        public static List<Games> Games { get; set; } = new List<Games> 
        {
            new Games
            {
                Id = 1,
                Title = "League of Pregnant",
                Description = "Be the better pregnant in the world",
                PEGI = 18,
                Price = 20,
                ReleaseDate = DateTime.Now.AddMonths(-20),
            },
            new Games
            {
                Id=2,
                Title = "Croquette League",
                Description = "Football and dog food",
                PEGI = 8,
                Price = 25,
                ReleaseDate = DateTime.Now.AddDays(-20)
            },
            new Games
            {
                Id = 3,
                Title = "Super Silly Soccer",
                Description = "A lighthearted and comedic take on soccer, where players can use hilarious power-ups and abilities to score goals.",
                PEGI = 3,
                Price = 30,
                ReleaseDate = DateTime.Now.AddMonths(-15)
            },
            new Games
            {
                Id = 4,
                Title = "Dance Dance Revolution Extreme",
                Description = "A high-energy rhythm game that challenges players to keep up with the beat of catchy songs while performing exaggerated dance moves.",
                PEGI = 12,
                Price = 25,
                ReleaseDate = DateTime.Now.AddMonths(-10)
            },
            new Games
            {
                Id = 5,
                Title = "Cooking Chaos",
                Description = "A frantic cooking game that tasks players with preparing and serving meals under intense time constraints and amidst hilarious distractions.",
                PEGI = 7,
                Price = 20,
                ReleaseDate = DateTime.Now.AddMonths(-5)
            },
            new Games
            {
                Id = 6,
                Title = "Wobbly Golf",
                Description = "A physics-based golf game where players must overcome bizarre obstacles and gravity-defying challenges to reach the hole.",
                PEGI = 3,
                Price = 30,
                ReleaseDate = DateTime.Now.AddMonths(-2)
            },
            new Games
            {
                Id = 7,
                Title = "Animal Shenanigans",
                Description = "A party game filled with silly mini-games and challenges that involve animal-themed actions and interactions.",
                PEGI = 3,
                Price = 25,
                ReleaseDate = DateTime.Now.AddMonths(-1)
            },
            new Games
            {
                Id = 8,
                Title = "Ultra-Mega Robot Battle",
                Description = "A fast-paced action game where players control giant robots and engage in epic battles.",
                PEGI = 12,
                Price = 35,
                ReleaseDate = DateTime.Now.AddMonths(-6)
            },
            new Games
            {
                Id = 9,
                Title = "Cosmic Cat Adventure",
                Description = "A colorful platformer game where players guide a spacefaring cat through a variety of intergalactic challenges.",
                PEGI = 3,
                Price = 20,
                ReleaseDate = DateTime.Now.AddMonths(-4)
            },
                    new Games
                    {
                Id = 10,
                Title = "Time Warp Puzzler",
                Description = "A mind-bending puzzle game that involves manipulating time to solve challenging physics-based puzzles.",
                PEGI = 7,
                Price = 25,
                ReleaseDate = DateTime.Now.AddMonths(-3)
            },
            new Games
            {
                Id = 11,
                Title = "Musical Mayhem",
                Description = "A rhythm game where players must match the rhythm of their actions to the beat of catchy music.",
                PEGI = 3,
                Price = 20,
                ReleaseDate = DateTime.Now.AddMonths(-2)
            },
        };
    }
}
