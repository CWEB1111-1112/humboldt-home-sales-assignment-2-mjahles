using System;
using System.Collections.Generic;

namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            int attendantId;
            string attendantName;
            int dogId;
            string dogName;
            int timeWithDog;
            char services;
            string dogNote;
        }
    }
    class Dog
    {
        public int attendantId {get;set;}
        public string attendantName {get; set;}
        public int wooferId {get; set;}
        public string wooferName {get; set;}
        public int timeWithWoofer {get; set;}
        public char services {get; set;}
        public string wooferNote {get; set;}

        public Log(int attendantId, string attendantName, int wooferId, string wooferName, int timeWithWoofer, char services, string wooferNote)
        {
            this.attendantId = attendantId;
            this.attendantName = attendantName;
            this.wooferId = wooferId;
            this.wooferName = wooferName;
            this.timeWithWoofer = timeWithWoofer;
            this.services = services;
            this.wooferNote = wooferNote;
        }
    }
}
