using System;
namespace C_learning 
{

    class Program 
    {

        static void Main()
        {
            System.Console.Write("Введите переменную x = ");
            double x = double.Parse(System.Console.ReadLine());
            
            System.Console.Write("Введите переменную y = ");
            double y = double.Parse(System.Console.ReadLine());

            const int r = 2;

            if ((x>0 && y>0)||(x>0 && y<0))
            {
                if (Math.Abs(x)+Math.Abs(y)<r)
                    System.Console.WriteLine("Да");
                else 
                    if (Math.Abs(x)+Math.Abs(y)>r)
                        System.Console.WriteLine("Нет");
                    else 
                        System.Console.WriteLine("На границе");
            }
            else
                if (x*x + y*y < r*r)
                    System.Console.WriteLine("Да");
                else
                    if (x*x + y*y > r*r)
                        System.Console.WriteLine("Нет");
                    else
                        System.Console.WriteLine("На границе");
        }   
         

    }

}