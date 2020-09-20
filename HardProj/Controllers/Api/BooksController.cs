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
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var context = new Context();
            var book = context.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return BadRequest("Неверный id");
            }

            return Ok(book);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Create(Book book)
        {
            if (book == null)
            {
                return BadRequest("Не введена информация");
            }

            var context = new Context();
            context.Books.Add(book);
            context.SaveChanges();

            return Ok(book);
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var context = new Context();
            var book = context.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return BadRequest("Не введен id");
            }

            context.Books.Remove(book);
            context.SaveChanges();

            return Ok("Книга удалена!");
        }
    }
}
