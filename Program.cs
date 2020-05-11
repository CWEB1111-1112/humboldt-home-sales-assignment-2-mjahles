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
                Console.WriteLine("Please input the care attendant ID (input 999 to exit):");
                attendantId = Convert.toInt32(Console.ReadLine());
                if(attendantId != END){ //Statement that checks if the user input 999 to end the loop
                    Console.WriteLine("Please input the care attendant's name:");
                    attendantName = Console.ReadLine();
                    Console.WriteLine("Please input the dog's ID number:");
                    dogId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the dog's name:");
                    dogName = Console.ReadLine();
                    Console.WriteLine("Please input the time spent caring for the dog:");
                    timeWithDog = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the services provided to the dog:\n[B] Bath, [G] Grooming, [N] None");
                    services = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Please input a general note about the dog's day and temperment:");
                    dogNote = Console.ReadLine();
                    //Adding the data to the Log list
                    
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
