using System;

    class Program
    {
            
        static void Main(string[] args)
        {
            // && - и
            // || - или
            int [] numbers = {2, 3, 4, 3, 2};
            int len = numbers.Length;
            for(int i = 0; i < len; i++)
            {
            if(numbers[0] == numbers[4] && numbers[1] == numbers[3]) // false  true
            {
               Console.WriteLine("палиндром"); 
            }
            Console.WriteLine("NO");
        }
    }}