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
    [RoutePrefix("api/ganre")]
    public class GanreController : ApiController
    {
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var context = new Context();
            var ganre = context.Ganres.FirstOrDefault(x => x.Id == id);
            
            if (ganre == null)
            {
                return BadRequest("Неверный id");
            }

            return Ok(ganre);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Create(Ganre ganre)
        {
            if (ganre == null)
            {
                return BadRequest("Не введена информация по автору");
            }

            var context = new Context();
            context.Ganres.Add(ganre);
            context.SaveChanges();

            return Ok(ganre);
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete (int id)
        {
            var context = new Context();
            var ganre = context.Ganres.FirstOrDefault(x => x.Id == id);

            if (ganre == null)
            {
                return BadRequest("Не введен id автора");
            }

            context.Ganres.Remove(ganre);
            context.SaveChanges();

            return Ok("Жанр удалён!");
        }
    }
}
