using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDBMockProject.Models;
using MongoDBMockProject.Repositories;

namespace MongoDBMockProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            var id = await _studentRepository.Create(student);
            return new JsonResult(id.ToString());
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var student = await _studentRepository.Get(ObjectId.Parse(id));
            return new JsonResult(student);
        }

        [HttpGet("getByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var student = await _studentRepository.GetByName(name);
            return new JsonResult(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Student Student)
        {
            var student = await _studentRepository.Update(ObjectId.Parse(id), Student);

            return new JsonResult(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var student = await _studentRepository.Delete(ObjectId.Parse(id));

            return new JsonResult(student);
        }

        [HttpGet("Fetch")]
        public async Task<IActionResult> GetAll()
        { 
            var students = await _studentRepository.GetAll();
            return new JsonResult(students);
        }


    }
}
