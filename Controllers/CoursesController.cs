using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CoursesAPI.Models;
using CoursesAPI.DataRepository;

namespace CoursesAPI.Controllers
{
    public class CoursesController : ApiController
    {
        readonly SampleData courses = new SampleData();

        // Get all available courses
        public IEnumerable<Course> GetAllCourses()
        {
            return courses.GetRepository();
        }

        // Get course by Id
        public IHttpActionResult GetCourseById(int id)
        {
            var course = courses.GetRepository().FirstOrDefault(c => c.Id == id);
            if(course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // Get courses by category ("G" or "C")
        public IEnumerable<Course> GetCourseByCategory(string cat)
        {
            return courses.GetRepository().Where(c => c.Category.StartsWith(cat, StringComparison.OrdinalIgnoreCase));
        }
    }
}
