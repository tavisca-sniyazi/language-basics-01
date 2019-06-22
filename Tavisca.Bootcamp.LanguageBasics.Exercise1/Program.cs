using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
           
            string[] digits = equation.Split(new char[] { '*','=' });

            if(digits[0].Contains('?'))
            {
                int b = Int32.Parse(digits[1]);
                int c = Int32.Parse(digits[2]);

                if(c%b!=0)
                {
                    return (-1);
                }

                int a = c / b;
                string x = a.ToString();
                int index = 0;
                int same = 0;
                string A = digits[0];

                if(x.Length==A.Length)
                {
                    for(int i=0;i<x.Length;i++ )
                    {
                        if(A[i]=='?')
                        {
                            index = i; continue;
                        }
                        if(A[i]==x[i])
                        {
                            same = same + 1;

                        }
                    }

 
                }

                else
                {
                    return (-1);
                }
                if(same==x.Length-1)
                {
                    string y = x[index].ToString();
                    int z = Int32.Parse(y);
                    return (z);
                }
                else
                {
                    return (-1);
                }
            }


            if (digits[1].Contains('?'))
            {
                int a = Int32.Parse(digits[0]);
                int c = Int32.Parse(digits[2]);

                if (c % a != 0)
                {
                    return (-1);
                }

                int b = c / a;
                string x = b.ToString();
                int index = 0;
                int same = 0;
                string A = digits[1];

                if (x.Length == A.Length)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (A[i] == '?')
                        {
                            index = i; continue;
                        }
                        if (A[i] == x[i])
                        {
                            same = same + 1;

                        }
                    }


                }

                else
                {
                    return (-1);
                }
                if (same == x.Length - 1)
                {
                    string y = x[index].ToString();
                    int z = Int32.Parse(y);
                    return (z);
                }
                else
                {
                    return (-1);
                }
            }

            if (digits[2].Contains('?'))
            {
                int a = Int32.Parse(digits[0]);
                int b = Int32.Parse(digits[1]);

                int c = a * b;
                string x = c.ToString();
                int index = 0;
                int same = 0;
                string A = digits[2];

                if (x.Length == A.Length)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (A[i] == '?')
                        {
                            index = i; continue;
                        }
                        if (A[i] == x[i])
                        {
                            same = same + 1;

                        }
                    }


                }

                else
                {
                    return (-1);
                }
                if (same == x.Length - 1)
                {
                    string y = x[index].ToString();
                    int z = Int32.Parse(y);
                    return (z);
                }
                else
                {
                    return (-1);
                }
            }
            return 0;
        }
    }
}
