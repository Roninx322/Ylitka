using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapolnYlitkoi
{
    class Program
    {
        public int[,] create(int[,] mass)
        {
            int i;
            int j;
            int k = 1;
            int m = mass.GetLength(0);
            int n = mass.GetLength(1);
            Random rnd = new Random();
            i = 0;
            j = 0;
            int x = mass.GetLength(0) * mass.GetLength(1);
            int x1 = 0;
            do
            {   
                for (j = j; j < n-1; j++)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                
                
                for (i = i; i < m-1; i++)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                n--;
                m--;
                for (j = j; j>= mass.GetLength(1)-n; j--)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                
                for (i = i; i > mass.GetLength(0)-m-1; i--)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                i++; 
                j++;
            } while (x1 != x);
            Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
            Console.ReadLine();
            return (mass);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] mass = new int[n,m];
            Program t = new Program();
            mass=t.create(mass);
        }
    }
}
