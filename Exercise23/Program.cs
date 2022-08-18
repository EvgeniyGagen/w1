using System;
class Program
{
static void Main(string[] args)
    {
       Double x1, y1, z1, x2, y2, z2, S;

                        
        Console.Write("Введите  x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите  y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите  z1: ");
        z1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите  x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите  y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите  z2: ");
        z2 = Convert.ToDouble(Console.ReadLine());

        S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между  точками A и В  равно {S}");
        Console.ReadKey();
        
                
            
    }
    
}
