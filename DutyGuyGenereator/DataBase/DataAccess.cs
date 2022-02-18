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

        public static void EditStudent(Student student, string Name, string Surname, string NewSurname, string NewName)
        {
            var std = new MongoClient("mongodb://localhost");
            var database = std.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            var filterName = Builders<Student>.Filter.Eq("Name", Name);
            var updateName = Builders<Student>.Update.Set(x => x.Name, NewName);
            var filterSurname = Builders<Student>.Filter.Eq("Surname", Surname);
            var updateSurname = Builders<Student>.Update.Set(x => x.Surname, NewSurname);
            collection.UpdateOneAsync(filterSurname, updateSurname);
            collection.UpdateOneAsync(filterName, updateName);
        }

       public static Student[] GetDutyGuys()
       {
            Student[] result = new Student[2];
            Random random = new Random();
            var student = new MongoClient("mongodb://localhost");
            var database = student.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            var neededStudent = collection.Find(x => true).ToList();
            var first = neededStudent[random.Next(0, neededStudent.Count())];
            result[0] = first;
            var second = neededStudent[random.Next(0, neededStudent.Count())];

            while (true)
            {
                if (first != second)
                {
                    result[1] = second;
                    break;
                }
                second = neededStudent[random.Next(0, neededStudent.Count())];
            }
            return result;
       }
        public static void ReplaceStudent(Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            collection.DeleteOneAsync(x => x.Name == student.Name);
            
        }
    }
}
