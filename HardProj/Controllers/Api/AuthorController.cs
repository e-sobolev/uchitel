using HardProj.EF;
using HardProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Caching;
using System.Web.Http;

namespace HardProj.Controllers.Api
{
    [RoutePrefix("api/authors")]
    public class AuthorController : ApiController
    {
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var context = new Context();
            var author = context.Authors.FirstOrDefault(x => x.Id == id);
            
            if (author == null)
            {
                return BadRequest("Такого автора не существует");
            }

            return Ok(author);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Create(Author author)
        {
            if (author == null)
            {
                return BadRequest("Не введена информация об авторе");
            }

            var context = new Context();
            context.Authors.Add(author);
            context.SaveChanges();

            return Ok(author);
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var context = new Context();
            var author = context.Authors.FirstOrDefault(x => x.Id == id);

            if (author == null)
            {
                return BadRequest("Не введен id автора");
            }

            context.Authors.Remove(author);
            context.SaveChanges();

            return Ok("Автор удалён");
        }


    }
}
