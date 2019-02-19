using System;
using System.Collections.Generic;
using CoursesAPI.Models;

namespace CoursesAPI.DataRepository
{
    public class SampleData
    {
        // Sample data setup
        private List<Course> CourseData()
        {
            List<Course> courses = new List<Course>()
            {
                new  Course
                {   Id = 1,
                    Title = "Anatomy & Physiology",
                    Category = "General",
                    Price = 1100,
                    Credits = 30,
                    StartDate = new DateTime(01/01/2018)
                },
                new Course
                {   Id = 1,
                    Title = "Biology",
                    Category = "General",
                    Price = 1000,
                    Credits = 30,
                    StartDate = new DateTime(2/01/2018)
                },
                new Course
                {
                    Id = 2,
                    Title = "Anatomy I",
                    Category = "General",
                    Price = 900,
                    Credits = 20,
                    StartDate = new DateTime(02/19/2019)
                },
                new Course
                {
                    Id = 3,
                    Title = "Anatomy II",
                    Category = "General",
                    Price = 1000,
                    Credits = 30,
                    StartDate = new DateTime(01/10/2018)
                },
                new Course
                {
                    Id = 4,
                    Title = "Heart Rate Variability Recording and Feedback",
                    Category = "Cardiology",
                    Price = 1500,
                    Credits = 30,
                    StartDate = new DateTime(02/15/2018)
                },
                new Course
                {
                    Id = 5,
                    Title = "Heart catheterization",
                    Category = "Cardiology",
                    Price = 1500,
                    Credits = 30,
                    StartDate = new DateTime(02/15/2018)
                },
                new Course
                {
                    Id = 6,
                    Title = "Echocardiography",
                    Category = "Cardiology",
                    Price = 1500,
                    Credits = 30,
                    StartDate = new DateTime(01/20/2018)
                },
                new Course
                {
                    Id = 7,
                    Title = "Prevention of cardiovascular disease",
                    Category = "Cardiology",
                    Price = 1500,
                    Credits = 30,
                    StartDate = new DateTime(01/20/2018)
                }
            };

            return courses;
        }

        /// <summary>
        /// Get Course Repository
        /// </summary>
        /// <returns>Courses</returns>
        public List<Course> GetRepository()
        {
            return CourseData();
        }
    }
}
