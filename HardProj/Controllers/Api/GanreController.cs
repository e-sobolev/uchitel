using HardProj.EF;
using HardProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HardProj.Controllers.Api
{
    [RoutePrefix("api/genre")]
    public class GanreController : ApiController
    {
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var context = new Context();
            var genre = context.Genres.FirstOrDefault(x => x.Id == id);
            
            if (genre == null)
            {
                return BadRequest("Неверный id");
            }

            return Ok(genre);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Create(Genre genre)
        {
            if (genre == null)
            {
                return BadRequest("Не введена информация по автору");
            }

            var context = new Context();
            context.Genres.Add(genre);
            context.SaveChanges();

            return Ok(genre);
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete (int id)
        {
            var context = new Context();
            var genre = context.Genres.FirstOrDefault(x => x.Id == id);

            if (genre == null)
            {
                return BadRequest("Не введен id автора");
            }

            context.Genres.Remove(genre);
            context.SaveChanges();

            return Ok("Жанр удалён!");
        }
    }
}
