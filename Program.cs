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
            double timeWithDog;
            char services;
            string dogNote;
            const int END = 999;
            int x = 0;

            //List that contains info objects instances
            List<Log> dogCareLog = new List<Log>();

            //Intake of data
            while(x < x + 1){  //Loop that allows for continuous input of data
                Console.WriteLine("Please input the care attendant ID (input 999 to exit):");
                attendantId = Convert.ToInt32(Console.ReadLine());
                if(attendantId != END){ //Statement that checks if the user input 999 to end the loop
                    Console.WriteLine("Please input the care attendant's name:");
                    attendantName = Console.ReadLine();
                    Console.WriteLine("Please input the dog's ID number:");
                    dogId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the dog's name:");
                    dogName = Console.ReadLine();
                    Console.WriteLine("Please input the time spent caring for the dog (in hours):");
                    timeWithDog = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please input the services provided to the dog:\n[B] Bath, [G] Grooming, [N] None");
                    services = Convert.ToChar(Console.ReadLine());
                        while(services != 'B' && services != 'G' && services != 'N'){
                            Console.WriteLine("Please input a a valid service:\n[B] Bath, [G] Grooming, [N] None");
                            services = Convert.ToChar(Console.ReadLine());
                        }
                    Console.WriteLine("Please input a general note about the dog's day and temperment:");
                    dogNote = Console.ReadLine();
                    Console.WriteLine(""); //This added in for spacing between instances of the loop
                    //Adding the data to the Log list
                    Log aLog = new Log(attendantId, attendantName, dogId, dogName, timeWithDog, services, dogNote); //Creating an object instance of the dog object using the using input data
                    dogCareLog.Add(aLog); //Adding the created Log object to the dogCareLog list
                }
                else{
                    break; //This stops the loop if the sentinel value is entered
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
        public double timeWithWoofer {get; set;}
        public char services {get; set;}
        public string wooferNote {get; set;}

        public Log(int attendantId, string attendantName, int wooferId, string wooferName, double timeWithWoofer, char services, string wooferNote)
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
