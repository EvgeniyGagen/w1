﻿using System;

    class Program
    {
        
        static void Main(string[] args)
        {
            int[] A = {1, 8, 27, 64, 125};
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write("Куб от первого числа: ");
                Console.WriteLine(Math.Pow(A[0],3));                      
                Console.Write("Куб от второго числа: ");
                Console.WriteLine(Math.Pow(A[1],3));
                Console.Write("Куб от третьего числа: ");
                Console.WriteLine(Math.Pow(A[2],3));            
                Console.Write("Куб от четвертого числа: ");
                Console.WriteLine(Math.Pow(A[3],3));
                Console.Write("Куб от пятого числа: ");
                Console.WriteLine(Math.Pow(A[4],3));
                Console.WriteLine("y/n");
                if(Console.ReadLine() == "n") break;
            }
        }
    }