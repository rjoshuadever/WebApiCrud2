namespace WebApiCrud2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiCrud2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiCrud2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiCrud2.Models.ApplicationDbContext context)
        {

            context.Pokemons.AddOrUpdate(
                x => x.Name,
                new Pokemon {Name = "Pikachu", Type = "Electric" },
                new Pokemon {Name = "Charizard", Type = "Fire" },
                new Pokemon {Name = "Blastoise", Type = "Water" }

                );

        }
    }
}
