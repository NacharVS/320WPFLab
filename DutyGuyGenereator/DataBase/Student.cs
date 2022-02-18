using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DutyGuyGenereator.DataBase
{
    class Student
    {
        public Student(string surname, string name)
        {
            Name = name;
            Surname = surname;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        
    }
}
