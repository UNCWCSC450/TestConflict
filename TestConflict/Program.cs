using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TestConflict
{
    class Program
    {
        //ArrayList courseList = new ArrayList();
        
        static void Main(string[] args)
        {
            //DATABASE
            ReadDataBase();

            //SUBJECTS
            string subject1 = "";
            string subject2 = "";
            string subject3 = "";
            string subject4 = "";
            string subject5 = "";
            string subject6 = "";
            ArrayList subjectsList = new ArrayList() {};


            //COURSENUM
            string courNum1 = "";
            string courNum2 = "";
            string courNum3 = "";
            string courNum4 = "";
            string courNum5 = "";
            string courNum6 = "";
            ArrayList courseNumList = new ArrayList() { };

            //SECTION***
            string section1 = "";
            string section2 = "";
            string section3 = "";
            string section4 = "";
            string section5 = "";
            string section6 = "";
            ArrayList sectionsList = new ArrayList() { };

            //SEARCH CRITERIA 
            Boolean preferedOnline = false;
            ArrayList preferedDays = new ArrayList() {"M","T","W","R","F","S","U" };
            ArrayList preferedTimes = new ArrayList() {"Morning", "Noon", "Evening"};


            //Generate some data structure to store CRN, SUBJ, COURSENUM, SECTION, and bitArray for each course


            //string query = "SELECT crn,bitArray FROM course_table WHERE subject = "+subject1+" and coursenum ="+courNum1+"";


        }

        private static void ReadDataBase()
        {
            List<Course> courseList = new List<Course>();

            string queryStr = "Select * FROM Course_Table ORDER BY courses.course_table.Subj;";
            string ConnectionStr = "server=localhost; uid=root; pwd=12345; database=Courses";
            using (MySqlConnection connection = new MySqlConnection(ConnectionStr))
            {
                MySqlCommand command = new MySqlCommand(queryStr, connection);
                connection.Open();
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        Int32 crn = (Int32)reader["CRN"]; 
                        var subj = (string)reader["Subj"]; 
                        Int32 crse = (Int32)reader["Crse"];
                        Int32 sec = (Int32)reader["Sec"];
                        var cmp = (string)reader["Cmp"];
                        var cred = (string)reader["cred"];
                        var title = (string)reader["Title"];
                        var days = (string)reader["Days"];
                        var time = (string)reader["Time"];
                        Int32 seatsrem = (Int32)reader["Seats Rem"];
                        Int32 wlcap = (Int32)reader["WL CAP"];
                        Int32 wlact = (Int32)reader["WL Act"];
                        Int32 wlrem = (Int32)reader["WL Rem"];
                        Int32 rsrvdrem = (Int32)reader["Rsrvd Rem"];
                        var instructor = (string)reader["Instructor"];
                        var dates = (string)reader["Dates"];
                        var session = (string)reader["Session"];
                        var location = (string)reader["Location"];
                        var bitarray = reader["BITARRAY"];

                        Course course = new Course(crn, subj, crse, sec, cmp, cred, title, days, time, seatsrem, wlcap, wlact, wlrem, rsrvdrem, instructor, dates, session, location, bitarray);
                        courseList.Add(course);
                    }

                    var c = courseList.Count;

                    Console.WriteLine(reader);
                    Console.ReadLine();
                }
                finally
                {
                    // Always call Close when done reading.
                    connection.Close();
                }

            }
        }
    }
}
