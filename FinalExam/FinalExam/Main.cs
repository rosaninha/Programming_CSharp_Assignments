using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showmenu = true;
            while (showmenu)
            {
                showmenu = mainmenu();
            }
        }


        private static bool mainmenu()
        {
            {
                Console.WriteLine("\r\nHello ");
                Console.WriteLine("\r\nChoose any Question: ");
                Console.WriteLine("1. **GetMyInfo**");
                Console.WriteLine("2. **Number of Characters**");
                Console.WriteLine("3. **Odd and Even Number**");
                Console.WriteLine("4. **Count to TEN**");
                Console.WriteLine("5. **Add and Multiplication**");
                Console.WriteLine("6. **Day of the week**");
                Console.WriteLine("7. **Positive or Negative Number**");
                Console.WriteLine("8. **Upper Case**");
                Console.WriteLine("9. **Assending Order in Numbers**");
                Console.WriteLine("10. **Factorial Number**");
                Console.WriteLine("11. Exit the Menu");
                Console.WriteLine("\r\nSelect an Item:");
            }
            switch (Console.ReadLine())
            {
                case "1":
                    Q1();
                    return true;
                case "2":
                    Q2();
                    return true;
                case "3":
                    Q3();
                    return true;
                case "4":
                    Q4();
                    return true;
                case "5":
                    Q5();
                    return true;
                case "6":
                    Q6();
                    return true;
                case "7":
                    Q7();
                    return true;
                case "8":
                    Q8();
                    return true;
                case "9":
                    Q9();
                    return true;
                case "10":
                    Q10();
                    return true;

                case "11":
                    return false;
                default:
                    return true;
            }
        }

        private static void Q1()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Q1. **GetMyInfo **");
                DateTime now = DateTime.Now;
                Console.WriteLine("\nRosana Silva " + now);
                Console.ReadLine();
                Console.Clear();
            }
            catch
            {

            }
        }

        private static void Q2()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Q2. **Number of Characters**");
                Console.WriteLine("\nWrite a Line: ");

                string V = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("( " + V + " ) This Line has: " + V.Length + " characters.");

                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q3()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Q3. **Odd and Even Number**");
                int i;
                Console.Write("\nEnter a Number : ");
                i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.Write("Entered Number is an Even Number");
                    Console.Read();
                }
                else
                {
                    Console.Write("Entered Number is an Odd Number");
                    Console.Read();

                    Console.ReadKey();
                }
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q4()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Q4. **Count to TEN**");
                int i;
                Console.WriteLine("\nThe first 10 natural number are:");

                for (i = 1; i <= 10; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("\n\n");
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q5()
        {
            try
            {


                Console.Clear();
                Console.WriteLine("Q5. **Add and Multiplication**");
                Console.WriteLine("\nEnter the first number:  ");
                int N1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number: ");
                int N2 = Convert.ToInt32(Console.ReadLine());

                int totalA = (N1 + N2);
                int totalM = (N1 * N2);

                Console.WriteLine("The ADD(+) of two Numbers: " + totalA);
                Console.WriteLine("The Multiplication(*) of two Numbers:  " + totalM);
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }
        }
        private static void Q6()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Q6. **Day of the week**");

                Console.WriteLine("\nPut Month in Number: ");
                int M = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Put Day in Number: ");
                int D = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Put the Year (4 digits): ");
                int Y = Convert.ToInt32(Console.ReadLine());

                Console.Write("The Date is: " + "" + M + "/" + D + "/" + Y);

                DateTime dateValue = new DateTime(Y, M, D);

                Console.WriteLine(" is: " + " " + dateValue.ToString("dddd"));

                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q7()
        {
            try
            {


                Console.Clear();
                Console.WriteLine("Q7. **Positive or Negative Number**");

                int num;
                Console.Write("\n\n");
                Console.Write("Check whether a number is positive or negative:\n");
                Console.Write("\n\n");
                Console.Write("Input a Number : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)

                    Console.WriteLine("POSITIVE.\n", num);
                else
                    Console.WriteLine("NEGATIVE. \n", num);


                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q8()
        {
            try
            {

                Console.Clear();
                Console.WriteLine("Q8. **Upper Case**");
                string S1;
                char[] A1;
                int l, i;
                l = 0;
                char ch;
                Console.Write("\n\n***Replace lowercase characters by uppercase****\n");
                Console.Write("Input the letters: ");
                S1 = Console.ReadLine();
                l = S1.Length;
                A1 = S1.ToCharArray(0, l);

                Console.Write("\nAfter convert, the UPPER Letters are : ");
                for (i = 0; i < l; i++)
                {
                    ch = A1[i];
                    if (Char.IsLower(ch))
                        Console.Write(Char.ToUpper(ch));
                    else
                        Console.Write(Char.ToUpper(ch));
                }
                Console.Write("\n\n");

                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q9()
        {
            try
            {

                Console.Clear();
                Console.WriteLine("Q9. **Assending Order in Numbers**");
                int[] A1 = { N1, N2, N3, };

                int[] A2 = { N4, N5, N6, };

                int[] A3 = new int[A1.Length + A2.Length];
                A3 = A1.Concat(A2).ToArray();

                Array.Sort(A3);

                foreach (int i in A3)
                {
                    Console.Write("\n" + i + " ");
                }
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
        private static void Q10()
        {
            try
            {


                Console.Clear();
                Console.WriteLine("Q10. **Factorial Number**");
                Console.WriteLine("\nPut the Numbers : ");
                float V = Convert.ToInt32(Console.ReadLine());

                float T = 1;

                for (int i = 1; i <= V; i++)
                {
                    Console.WriteLine("F is : " + T + " and N is: " + i);
                    T *= i;
                }

                Console.WriteLine("Number is: " + V + " Factrial is: " + T + "!");
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {

            }

        }
    }
}