using System;
using System.Collections.Generic;
namespace listsAssignment
{
    class Program
    {
        static int getInt(string message)
        {
            int n;
            Console.WriteLine(message);
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                } catch (Exception e)
                {
                    Console.WriteLine("You need to provide an integer.");
                }
            }
            return n;

        }
        
        static int menu(string message, int numOptions)
        {
            int n;
            while (true)
            {
                n = getInt(message);
                if (n < 0 || n > numOptions)
                {
                    Console.WriteLine("not a valid menu option.");
                    continue;
                } 
                else
                {
                    break;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            string menuMessage = "0. quit\n1. student names\n2. add students \n3. delete student\n4. amount of buses";
            int menuOption;

            int j;
            string[] input = { "", "", "", "" };
            List<string> colors = new List<string>(input); 
            while (true)
            {
                try
                {
                    //j = getInt();
                } catch (Exception e)
                {

                }
            }


            Console.ReadKey();



          
        }
    }
    
}
