 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

   

            Console.Write(" Enter The first Number :  ");
            int firstnum = int.Parse(Console.ReadLine());       

            Console.Write(" Enter The Last Number :  ");
            int lastnum = int.Parse(Console.ReadLine());       

            for (int num = firstnum; num <= lastnum; num++)   
            {
                int c = 0;                                  
                for (int k = 2; k <= num/2; k++)           
                {
                    if (num % k == 0)                      
                    {                                     
                        c++;                            
                       break;                           
                    }                                       
                } 
                if (c == 0 && num != 1 && num != 0)
                { 
                  Console.WriteLine(num);          
                }                                   
            }
                                                  
            Console.WriteLine("\n");




        }   

    }
}
