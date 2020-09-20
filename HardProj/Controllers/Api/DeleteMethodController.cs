//using HardProj.EF;
//using HardProj.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace HardProj.Controllers.Api
//{
//    [RoutePrefix("del/")]
//    public class DeleteMethodController : ApiController
//    {
//        [Route("{id}")]
//        [HttpGet]
//        public IHttpActionResult Get(int id)
//        {
//            var context = new Context();
//            var phone = context.DeleteMethods.FirstOrDefault(x => x.Id == id);

//            if (phone == null)
//            {
//                return BadRequest("Неверный id");
//            }

//            return Ok(phone);
//        }

//        [Route("")]
//        [HttpPost]
//        public IHttpActionResult Create(DeleteMethod deleteMethod)
//        {
//            if (deleteMethod == null)
//            {
//                return BadRequest("Не введена информация по книге");
//            }

//            var context = new Context();
//            context.DeleteMethods.Add(deleteMethod);
//            context.SaveChanges();

//            return Ok(deleteMethod);
//        }

//        [Route("{id}")]
//        [HttpDelete]
//        public IHttpActionResult Delete(int id)
//        {
//            var context = new Context();
//            var phone = context.DeleteMethods.FirstOrDefault(x => x.Id == id);

//            if (phone == null)
//            {
//                return BadRequest("Не введен id");
//            }

//            context.DeleteMethods.Remove(phone);
//            context.SaveChanges();

//            return Ok("Книга удалена!");
//        }

//    }
//}
