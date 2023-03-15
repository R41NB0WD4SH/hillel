using System;

namespace Lesson1_HW
{
    class Programm
    {

        static void Main(string[] args)
        {


            // GetSum();

            Console.WriteLine(GetSum());

            Console.ReadKey();









        }

        public static int GetSum()
        {
            int result = 0;
            for (int i = 0; i < 100; i++)
            {
                result += i;
            }

            return result;
        }
        
        
        
    }
    
    
    
    
}

