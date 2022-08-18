using System;
class Program
{
static void Main(string[] args)
    {
       int n = 3;
       int [] A = new int[n];
       int i = 0;
       Console.WriteLine("Введите точку А");
       while(i < n)
       {
            A[i] = Convert.ToInt32(Console.ReadLine()); i++;
       }
        int [] B = new int[n];
        int j = 0;
        Console.WriteLine("Введите точку B");
       while(j < n)
       {
            B[j] = Convert.ToInt32(Console.ReadLine()); j++;
       }
                        
        
        Console.Write($"Расстояние между  точками A и В  равно: ");
        Console.WriteLine(Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2)));
        
        
        
                
            
    }
    
}