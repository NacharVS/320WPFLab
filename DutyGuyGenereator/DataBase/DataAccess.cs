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
    }
}
