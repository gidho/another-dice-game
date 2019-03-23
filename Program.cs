using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //for delay
using System.Threading.Tasks;

namespace dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, sum, dice1, dice2, Q;
            string y;
            bool GoOn = true;
            Random rnd = new Random();
            
            Console.WriteLine("welcome");
            Console.WriteLine("");

            while (GoOn)
            {
                count = 0;
                Console.WriteLine("choose a number between 1 and 13");
                
                if(!int.TryParse(Console.ReadLine(), out Q) || Q < 2 || Q > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not paying attentention, try again...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                else
                {
                    Console.WriteLine("you have typed number: {0}", Q);
                    Console.WriteLine("-------------------------");
                    
                    do
                    {
                        dice1 = rnd.Next(1, 7);
                        dice2 = rnd.Next(1, 7);
                        sum = dice1 + dice2;
                        count++;

                        Console.WriteLine(dice1 + " and " + dice2 + " |   #" + count + " attempts");
                    } while (som != Q);

                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Do you wan't to try again? Press y");
                    y = Convert.ToString(Console.ReadLine());

                    if (y != "y")
                    {
                        GoOn = false;
                        Console.WriteLine("See you next time!");
                        Thread.Sleep(500);
                        Console.Write("*  ");
                        Thread.Sleep(400);
                        Console.Write("*  ");
                        Thread.Sleep(300);
                        Console.Write("*  ");
                        Thread.Sleep(200);
                        Environment.Exit(0);
                    }
                    Console.Clear();
                }              

            }            
                                             
        }
    }
}
