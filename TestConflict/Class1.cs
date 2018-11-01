using System;
using System.Collections.Generic;
using System.Text;

namespace TestConflict
{
    class Course
    {
        public string CRN { get; }
        public string Crse { get; }
        public string Sec { get; }
        public string Cmp { get; }
        public string Cred { get; }
        public string Title { get; }
        public string Days{ get; }
        public string Time { get; }
        public string SeatsRem { get; }
        public string WLCAP { get; }
        public string WLACT { get; }
        public string WLREM { get; }
        public string RsrvdRem { get; }
        public string Instructor { get; }
        public string Dates{ get; }
        public string Session { get; }
        public string Location { get; }
        public string BitArray { get; }


        public Course(string CRN, string Crse, string Sec, string Cmp, string Cred, string Title, string Days, string Time,
                        string SeatsRem, string WLCAP, string WLACT, string WLREM, string RsrvdRem, string Instructor, string Dates, string Session, string Location, string BitArray)
        {
            this.CRN = CRN;
            this.Crse = Crse;
            this.Sec = Sec;
            this.Cmp = Cmp;
            this.Cred = Cred;
            this.Title = Title;
            this.Days = Days;
            this.Time = Time;
            this.SeatsRem = SeatsRem;
            this.WLCAP = WLCAP;
            this.WLACT = WLACT;
            this.WLREM = WLREM;
            this.RsrvdRem = RsrvdRem;
            this.Instructor = Instructor;
            this.Dates = Dates;
            this.Session = Session;
            this.Location = Location;
            this.BitArray = BitArray;
        }







    }
}
