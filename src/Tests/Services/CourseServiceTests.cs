using Microsoft.VisualStudio.TestTools.UnitTesting;
using OL.Core.Contracts.Services;
using OL.Core.Model;
using OL.Infrastructure.Services;
using System.Threading.Tasks;

namespace OL.Tests
{
    [TestClass]
    public class CourseServiceTests : BaseTestDbContext
    {
        ICourseService _courseService;

        [TestInitialize]
        public void SetUp()
        {
            _courseService = new CourseService(InMemoryApplicationDbContext);

            AddSeedData(x => _courseService.Add(new Course
            {
                Id = 1,
                Name = "Foundations: Data, Data, Everywhere",
                Discription = "This is the first course in the Google Data Analytics Certificate. These courses will equip you with the skills you need to apply to introductory-level data analyst jobs. Organizations of all kinds need data analysts to help them improve their processes, identify opportunities and trends, launch new products, and make thoughtful decisions. In this course, you’ll be introduced to the world of data analytics through hands-on curriculum developed by Google. The material shared covers plenty of key data analytics topics, and it’s designed to give you an overview of what’s to come in the Google Data Analytics Certificate. Current Google data analysts will instruct and provide you with hands-on ways to ",
                ImageGuid = "f1bc1590455c4a8e842056cc7c1da7c4"
            }));
        }

        [TestMethod]
        public async Task GetCourseById_NotFound()
        {
            var result = await _courseService.GetById(2);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetCourseById_Found()
        {
            var course = new Course
            {
                Id = 1,
                Name = "Foundations: Data, Data, Everywhere",
                Discription = "This is the first course in the Google Data Analytics Certificate. These courses will equip you with the skills you need to apply to introductory-level data analyst jobs. Organizations of all kinds need data analysts to help them improve their processes, identify opportunities and trends, launch new products, and make thoughtful decisions. In this course, you’ll be introduced to the world of data analytics through hands-on curriculum developed by Google. The material shared covers plenty of key data analytics topics, and it’s designed to give you an overview of what’s to come in the Google Data Analytics Certificate. Current Google data analysts will instruct and provide you with hands-on ways to ",
                ImageGuid = "f1bc1590455c4a8e842056cc7c1da7c4"
            };


            InMemoryApplicationDbContext.Courses.Add(course);
            await InMemoryApplicationDbContext.SaveChangesAsync();


            var result = await _courseService.GetById(course.Id);
            Assert.IsNotNull(result);
        }
    }
}