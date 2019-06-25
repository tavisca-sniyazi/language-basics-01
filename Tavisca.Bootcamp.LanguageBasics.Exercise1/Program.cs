using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program : FixMultiplication
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
        }
    public class FixMultiplication
    {
        public static int FindDigit(string equation)
        {
            // Add your code here.
           
            string[] digits = equation.Split(new char[] { '*','=' });

            if (digits[0] == null || digits[1] == null || digits[2] == null)
                return -1;
            //for first digit
            if(digits[0].Contains('?'))
            {
                bool ifsucess1 = Int32.TryParse(digits[1], out int b);
                bool ifsucess2 = Int32.TryParse(digits[2], out int c);

                if(c%b!=0)
                {
                    return (-1);
                }

                int a = c / b;
                string temp_a = a.ToString();
                int index = 0;
                int same = 0;
                string A = digits[0];

                if(temp_a.Length==A.Length)
                {
                    for(int i=0;i<temp_a.Length;i++ )
                    {
                        if(A[i]=='?')
                        {
                            index = i; continue;
                        }
                        if(A[i]==temp_a[i])
                        {
                            same = same + 1;

                        }
                    }

 
                }

                else
                {
                    return (-1);
                }
                if(same==temp_a.Length-1)
                {
                    string y = temp_a[index].ToString();
                    bool  ifsucess3= Int32.TryParse(y, out int z);
                    return (z);
                }
                else
                {
                    return (-1);
                }
            }

            //for second digit

            if (digits[1].Contains('?'))
            {
                bool sucess = Int32.TryParse(digits[0], out int a);
                bool sucess1 = Int32.TryParse(digits[2], out int c);

                if (c % a != 0)
                {
                    return (-1);
                }

                int b = c / a;
                string temp_b = b.ToString();
                int index = 0;
                int same = 0;
                string B = digits[1];

                if (temp_b.Length == B.Length)
                {
                    for (int i = 0; i < temp_b.Length; i++)
                    {
                        if (B[i] == '?')
                        {
                            index = i; continue;
                        }
                        if (B[i] == temp_b[i])
                        {
                            same = same + 1;

                        }
                    }


                }

                else
                {
                    return (-1);
                }
                if (same == temp_b.Length - 1)
                {
                    string y = temp_b[index].ToString();
                    bool sucess2 = Int32.TryParse(y, out int z);
                    return (z);
                }
                else
                {
                    return (-1);
                }
            }
            //for third digit

            if (digits[2].Contains('?'))
            {
                bool sucess = Int32.TryParse(digits[0],out int a);
                bool sucess1 = Int32.TryParse(digits[1], out int b);

                int c = a * b;
                string temp_c = c.ToString();
                int index = 0;
                int same = 0;
                string C = digits[2];

                if (temp_c.Length == C.Length)
                {
                    for (int i = 0; i < temp_c.Length; i++)
                    {
                        if (C[i] == '?')
                        {
                            index = i; continue;
                        }
                        if (C[i] == temp_c[i])
                        {
                            same = same + 1;

                        }
                    }


                }

                else
                {
                    return (-1);
                }
                if (same == temp_c.Length - 1)
                {
                    string y = temp_c[index].ToString();
                    bool sucess2 = Int32.TryParse(y,out int z);
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

