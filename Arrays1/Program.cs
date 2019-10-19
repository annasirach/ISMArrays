using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
   {
        static void Main(string[] args)
        {
                Console.WriteLine("Сколько элементов будет в массиве?");
                int n = Int32.Parse(Console.ReadLine());
                double[] arr = new double[n];
                 Random rnd = new Random();
                 Console.WriteLine("Массив:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                     arr[i] = rnd.Next(-10, 15) / 2.5;
                     Console.Write(arr[i] + "  ");
                     }
                 Console.WriteLine();
                Console.WriteLine("Сумма отрицательных чисел массива  - {0}", Minus(arr));
                int nomermax = 0;
                double max = Max(ref nomermax, arr);
                Console.WriteLine("Максмальный элемент массива  - {0}", max);
                Console.WriteLine("Индекс максимального элемента массива - {0}", nomermax);
                Console.WriteLine("Максимальный за модулем элемент массива - {0}", MaxEl(arr));
                Console.WriteLine("Сумма индексов положительных эелементов - {0}", SumaInd(arr));
                Console.WriteLine("Кол-во целых чисел в массиве - {0}", Suma(arr));

            
        }


           /* static void Random(double[] arr)
            {
                Random rnd = new Random();
                Console.WriteLine("Массив:");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(-10, 15)/2.5;
                    Console.Write(arr[i] + "  ");
                }
                Console.WriteLine();
            }*/

            static double Minus(double[] arr)
            {
                double sumamin = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                        sumamin += arr[i];
                }
                return sumamin;
            }

            static double Max(ref int nomermax, double[] arr)
            {
                double max = -11;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        nomermax = i;
                    }
                }
                return max;
            }

            static double MaxEl(double[] arr)
            {
                double maxel = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Math.Abs(arr[i]) > Math.Abs(maxel))
                    {
                        maxel = arr[i];
                    }
                }
                return maxel;
            }
            static double SumaInd(double[] arr)
            {
                double sumaind = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        sumaind += i;
                    }
                }
                return sumaind;
            }

            static double Suma(double[] arr)
            {
                double suma = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] * 10) % 10 == 0)
                    {
                        suma++;
                    }
                }
                return suma;
            }


    }
}
