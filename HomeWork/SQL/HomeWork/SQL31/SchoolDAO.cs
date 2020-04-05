using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL31HW
{
    class SchoolDAO : ISchoolDAO
    {
        static SQLiteConnection Conncetion;

        public static string dbName = @"C:\sqllite\SQL31HW.db";

        static SchoolDAO()
        {
            Conncetion = new SQLiteConnection($"Data Source  = {dbName}; Version= 3;");
            Conncetion.Open();
        }

        public Dictionary<ClassRoom, List<Student>> GetMapClassToStudentsDictionary(Int64 n)
        {
            Dictionary<ClassRoom, List<Student>> diclass = new Dictionary<ClassRoom, List<Student>>();

            using (SQLiteCommand cmd  = new SQLiteCommand($"SELECT * FROM Class", Conncetion))
            {
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClassRoom classroom = new ClassRoom
                        {
                            Id = (Int64)reader["ID"],
                            Name = (string)reader["NAME"],
                            Code = (Int64)reader["code"],
                            NumberOfStudents = (Int64)reader["number_of_students"],
                            NumberOfVip = (Int64)reader["number_of_vip"],
                            AgeAverage = (Int64)reader["age_average"],
                            MostPopularCity = (string)reader["most_popular_city"],
                            OldestVip = (Int64)reader["oldest_vip"],
                            YoungestVip = (Int64)reader["youngest_vip"]
                        };
                        if (!diclass.ContainsKey(classroom))
                        {
                            diclass.Add(classroom, new List<Student>()); 
                        }
                        diclass[classroom] = GetStudentsFromClass(classroom.Id);
                    }
                }
            }
            return diclass;
        }

        public List<Student> GetStudentsFromClass(Int64 id)
        {
            List<Student> students = new List<Student>();
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *,class.NAME as class_NAME, students.NAME as students_NAME,class.id as class_id, students.id as students_id FROM students JOIN class ON students.class_id = class.id WHERE class.ID = {id} ", Conncetion))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            Id = (Int64)reader["students_id"],
                            Name = (string)reader["students_NAME"],
                            Age = (Int64)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            Vip = (string)reader["VIP"],
                            ClassID = (Int64)reader["class_id"]
                        };

                        ClassRoom ClassRoom = new ClassRoom
                        {
                            Id = (Int64)reader["class_id"],
                            Name = (string)reader["class_NAME"],
                            Code = (Int64)reader["code"],
                            NumberOfStudents = (Int64)reader["number_of_students"],
                            NumberOfVip = (Int64)reader["number_of_vip"],
                            AgeAverage = (Int64)reader["age_average"],
                            MostPopularCity = (string)reader["most_popular_city"],
                            OldestVip = (Int64)reader["oldest_vip"],
                            YoungestVip = (Int64)reader["youngest_vip"]
                        };
                        students.Add(student);


                    }
                }
            }

            return students;

        }
    }
}
