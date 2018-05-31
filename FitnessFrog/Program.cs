using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog
{
    class Program
    {
        static void Main()
        {
            double minutesExercised = 0;
            
            //Prompt the user for minutes exercised
            while(true) 
            {
                Console.Write("How many minutes did you exercise today or type quit to exit?      ");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    

                    try
                    {
                        double minutes = double.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not a valid number");
                            continue;
                        }

                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Not so good!");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Thats better!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be kidding");

                        }
                        else
                        {
                            Console.WriteLine("Now you're just showing off");
                        }

                        minutesExercised += minutes;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input!");
                        continue;
                    }

                    
                    

                    Console.WriteLine("Good, you have exercised " + minutesExercised + " minutes");
                }
                
            }
            Console.WriteLine("Good Bye");
                      
            
            
        }
    }
}
