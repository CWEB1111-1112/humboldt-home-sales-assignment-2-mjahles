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
            const string END = "999";
            int x = 0;

            //List that contains info objects instances
            List<Log> dogCareLog = new List<Log>();

            //Intake of data
            while(x > x;){  //Loop that allows for continuous input of data
                Console.WriteLine("Please input the Care Attendant ID (input 999 to exit):");
                attendantId = Convert.toInt32(Console.ReadLine());
                if(attendantId != END){ //Statement that allows the user to input 999 to end the loop

                }
            }
        }
    }
    //Separate class used for making the log object
    class Log
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
