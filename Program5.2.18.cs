using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetaArrayFromConsole(10);
            ShowArray(array, true);

            Console.ReadKey();

        }
        static int[] GetaArrayFromConsole(int num = 10)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());


            }
            return result;

        }
        static int[] SrotArray(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;

                    }
            return result;


        }
        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SrotArray(array);
            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        
        
        }


    }
}
