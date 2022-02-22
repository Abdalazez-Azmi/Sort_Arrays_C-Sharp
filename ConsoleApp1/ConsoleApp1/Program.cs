using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] numbers = new int[1, 2];
            int greater = 0;
        ask:  Console.WriteLine("Please Enter The First Number");
            numbers[0, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now Enter The Secound Number");
            numbers[0, 1] = Convert.ToInt32(Console.ReadLine());

                if (numbers[0, 0] > numbers[0, 1])
            { 
          
            greater = numbers[0, 0];
                numbers[0,0]=numbers[0, 1];
            numbers[0, 1] = greater;
                
                }
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                
               
            }
            Console.WriteLine("Try Another Number");
            goto ask;
            
            
          
            

            
          



            Console.ReadKey();  


        }
        
    }

}

