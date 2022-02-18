using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DutyGuyGenereator.DataBase
{
    class DataAccess
    {
        public static void AddStudentToDatabase(Student student)
        {
            var std = new MongoClient("mongodb://localhost");
            var database = std.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            collection.InsertOne(student);
        }
       
    }
}
