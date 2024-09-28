using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBMockProject.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Name    { get; set; }
        public string Address { get; set; }
        public string Phone   { get; set; }
    }
}
