using System;
using System.Collections.Generic;
using System.Text;

namespace TestConflict
{
    class Course
    {
        public Int32 CRN { get; }
        public string Subj { get; }
        public Int32 Crse { get; }
        public Int32 Sec { get; }
        public string Cmp { get; }
        public string Cred { get; }
        public string Title { get; }
        public string Days{ get; }
        public string Time { get; }
        public Int32 SeatsRem { get; }
        public Int32 WLCAP { get; }
        public Int32 WLACT { get; }
        public Int32 WLREM { get; }
        public Int32 RsrvdRem { get; }
        public string Instructor { get; }
        public string Dates{ get; }
        public string Session { get; }
        public string Location { get; }
        public object BitArray { get; }


        public Course(Int32 CRN, string Subj, Int32 Crse, Int32 Sec, string Cmp, string Cred, string Title, string Days, string Time,
                        Int32 SeatsRem, Int32 WLCAP, Int32 WLACT, Int32 WLREM, Int32 RsrvdRem, string Instructor, string Dates, string Session, string Location, object BitArray)
        {
            this.CRN = CRN;
            this.Subj = Subj;
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
