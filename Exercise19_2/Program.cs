using System;

    class Program
    {
            
        static void Main(string[] args)
        {
            // && - и
            // || - или
            int [] numbers = {1, 2, 8, 2, 1};
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
