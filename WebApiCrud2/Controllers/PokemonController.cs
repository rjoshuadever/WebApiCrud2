using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCrud2.Models;

namespace WebApiCrud2.Controllers
{
    public class PokemonController : ApiController
    {

        //GET ALL POKEMONS
        public IHttpActionResult Get()
        {

            List<Pokemon> pokemons;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                pokemons = db.Pokemons.ToList();
            }

            return Ok(pokemons);
        }


        //GET ONE POKEMON
        public IHttpActionResult Get(int id)
        {

            Pokemon pokemon;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                pokemon = db.Pokemons.Find(id);
            }

            return Ok(pokemon);
        }


        //Post New Pokemon
        public IHttpActionResult Post(Pokemon pokemon)
        {

            
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Pokemons.Add(pokemon);
                db.SaveChanges();
            }

            return Ok();
        }


        //Put Pokemon Method
        public IHttpActionResult PUT(Pokemon pokemon)
        {

            
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var currentPokemon = db.Pokemons.Find(pokemon.Id);
                currentPokemon.Name = pokemon.Name;
                currentPokemon.Type = pokemon.Type;
                db.SaveChanges();

            }

            return Ok();
        }

        //Delete Pokemon
        public IHttpActionResult DELETE(int id)
        {

             using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var currentPokemon = db.Pokemons.Find(id);
                db.Pokemons.Remove(currentPokemon);
                db.SaveChanges();

            }

             return Ok();

        }
    }
}
