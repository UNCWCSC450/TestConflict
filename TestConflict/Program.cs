using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace TestConflict
{
    class Program
    {
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


            string query = "SELECT crn,bitArray FROM course_table WHERE subject = "+subject1+" and coursenum ="+courNum1+"";


        }

        private static void ReadDataBase()
        {

            string queryStr = "Select * FROM Course_Table;";
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
                        var value1 = reader.GetValue(0); // On first iteration will be hello
                        var value2 = reader.GetValue(1); // On first iteration will be hello2
                        var value3 = reader.GetValue(2); // On first iteration will be hello3
                    }

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
