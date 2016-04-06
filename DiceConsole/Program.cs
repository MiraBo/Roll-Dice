using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             // Declare random number varable 
            Random rand = new Random();
            int roll = 0;
            int die1 = 0;
            int die2 = 0;
            

            //Console.WriteLine("Press Enter.. ");
            for (roll = 1; roll <= 100; roll++) 
            { 
                // Generate random number 
                die1 = rand.Next(1, 7); 
                die2 = rand.Next(1, 7);
               
                if (die1 == die2) 
                {
                   
                   Console.WriteLine("Roll " + roll + ": die1 " + die1 + " : die2 " + die2);
                 //Console.WriteLine("On roll " + roll + " you rolled doubles: " + die1 + " " + die2);
                
                }               
            }
            Console.ReadKey();
        }
       
    } 
        
 }

        
    

