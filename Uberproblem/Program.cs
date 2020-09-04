using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;

            Console.WriteLine("Hello Uber");
            int[] arrInput = { 3, 2, 1 };
            int[] arrOutput = new int[arrInput.Length];

            for (int i = 0; i < arrInput.Length; i++)
            {
                result = 1;

                for (int j = 0; j < arrInput.Length; j++)
                {
                    if (i != j)
                    {

                        result = (arrInput[j] * result);
                    }

                }
                arrOutput[i] = result;

                Console.WriteLine(result);
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
