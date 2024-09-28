using MongoDB.Bson;
using MongoDBMockProject.Models;

namespace MongoDBMockProject.Repositories
{
    public interface IStudentRepository
    {
        Task<ObjectId> Create(Student student);
        Task<Student> Get(ObjectId objectId);
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetByName(string Name);
        Task<bool> Update(ObjectId objectId, Student student);
        Task<bool> Delete(ObjectId objectId);
    }
}
