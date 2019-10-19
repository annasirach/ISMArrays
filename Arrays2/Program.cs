using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
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
                arr[i] = rnd.Next(-20, 20) / 2.5;
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
            double min; int num;
         double dob = Dob(arr, out min, out num);
         Console.WriteLine("Произведение элементов, размещенных после минимального({0}[{1}]) = {2}", min, num, dob);
         double minus; int nomerminus; double plus; int nomerplus;
         double suma1 = Suma1(arr, out minus, out nomerminus, out plus, out nomerplus);
         Console.WriteLine("Сумма элементов, размещенных между первым отрицательным({0}[{1}]) и вторым положительным({2}[{3}])" + " = {4}", minus, nomerminus, plus, nomerplus, suma1);
         double sumazero = Suma2(arr, out double zero1, out int ind1, out double zero2, out int ind2);
         Console.WriteLine("Сумма элементов, размещенных между первым({0}[{1}]) и последним({2}[{3}]) нулем = {4}", zero1, ind1, zero2, ind2, sumazero);
         double dobmax = DobMax(arr, out double max, out int indmax, out double minimal, out int indmin);
         Console.WriteLine("Произведение элементов, размещенных между максимальным({0}[{1}]) и минимальным({2}[{3}]) за модулем = {4}", max, indmax, minimal, indmin, dobmax);
       }

       static double Dob(double[] arr, out double min, out int num)
            {
                min = arr[0]; num = 0;
                double dob = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                    num = i;
                        min = arr[i];
                    }
                }
                for (int i = num + 1; i < arr.Length; i++)
                {
                    dob *= arr[i];
                }
                return dob;
            }

       static double Suma1(double[] arr, out double minus, out int nomerminus, out double plus, out int nomerplus)
            {
                double suma = 0;
                minus = arr[0];
                nomerminus = 0;
                plus = arr[0];
                nomerplus = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        nomerminus = i;
                        minus = arr[i];
                        break;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[j] > 0)
                            {
                                plus = arr[j];
                                nomerplus = j;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (nomerminus < nomerplus)
                {
                    for (int i = nomerminus + 1; i < nomerplus; i++)
                    {
                        suma += arr[i];
                    }
                }
                else if (nomerminus > nomerplus)
                {
                    for (int i = nomerplus + 1; i < nomerminus; i++)
                    {
                        suma += arr[i];
                    }
                }
                return suma;
            }

       static double Suma2(double[] arr, out double zero1, out int ind1, out double zero2, out int ind2)
        {
            double sumazero = 0;
            zero1 = arr[0]; ind1 = 0; zero2 = arr[0]; ind2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero1 = arr[i];
                    ind1 = i;
                    break;
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    zero2 = arr[i];
                    ind2 = i;
                    break;
                }
            }
            for (int i = ind1 + 1; i < ind2; i++)
            {
                sumazero += arr[i];
            }
            return sumazero;
        }

       static double DobMax(double[] arr, out double max, out int indmax, out double minimal, out int indmin)
        {
            double dobmax = 1;
            max = arr[0];
            indmax = 0;
            minimal = arr[0];
            indmin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                    indmax = i;
                }
                if (Math.Abs(arr[i]) < Math.Abs(minimal))
                {
                    minimal = arr[i];
                    indmin = i;
                }
            }
            if (indmin > indmax)
            {
                for (int i = indmax + 1; i < indmin; i++)
                {
                    dobmax *= arr[i];
                }
            }
            if (indmin < indmax)
            {
                for (int i = indmin + 1; i < indmax; i++)
                {
                    dobmax *= arr[i];
                }
            }
            return dobmax;
        }
    }
}
