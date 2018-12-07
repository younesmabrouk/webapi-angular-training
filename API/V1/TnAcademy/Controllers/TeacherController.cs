using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TnAcademy.Context;
using TnAcademy.Models;

namespace TnAcademy.Controllers
{
    public class TeacherController : ApiController
    {
        TnAcademyContext context = new TnAcademyContext();
        public IHttpActionResult GetAllTeachers()
        {
            try
            {
                var teachers = context.Teachers.ToList();
                return Ok(teachers);
            }
            catch(Exception e)
            {
                return InternalServerError();
            }
        }

        [Route("api/teacher/getById")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var teachers = context.Teachers.Find(id);
                return Ok(teachers);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Post([FromBody] Teacher teacher)
        {
            try
            {
                TnAcademyContext context = new TnAcademyContext();
                context.Teachers.Add(teacher);
                context.SaveChanges();
                return StatusCode(HttpStatusCode.Created);
            }
            catch(Exception e)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Put([FromBody] Teacher teacher)
        {
            try
            {
                TnAcademyContext context = new TnAcademyContext();
                context.Teachers.Attach(teacher);
                context.Entry(teacher).State = EntityState.Modified;
                context.SaveChanges();
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                TnAcademyContext context = new TnAcademyContext();
                Teacher teacher = context.Teachers.Find(id);
                context.Teachers.Remove(teacher);
                context.SaveChanges();
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }



    }
}
