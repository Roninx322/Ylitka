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
            int n = mass.GetLength(0);
            int m = mass.GetLength(1);
            Random rnd = new Random();
            i = 0;
            j = -1;
            int x = mass.GetLength(0) * mass.GetLength(1);
            int x1 = 0;
            do
            {   
                for (j = j+1; j < n; j++)
                {
                    mass[i, j] = rnd.Next(1, 10);
                    x1++;
                }
                
                j--;
                for (i = i+1; i < m; i++)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);  
                }
                i--;
                m--;
               
                for (j = j-1; j >mass.GetLength(0)-n; j--)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);  
                }
                
                n--;
                for (i = i; i > mass.GetLength(1)-m-1; i--)
                {
                    x1++;
                    mass[i, j] = rnd.Next(1, 10);  
                }
                i++;
                
            } while (x1 != x);
            Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
            Console.ReadLine();
            return (mass);
        }
        static void Main(string[] args)
        {
            int [,] mass = new int[5,5];
            Program t = new Program();
            mass=t.create(mass);
            
        }
    }
}
