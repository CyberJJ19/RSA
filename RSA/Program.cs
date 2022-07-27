using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    static class Program
    {
        /// </summary>
        [STAThread]
        public static int Euclidean(int x, int y)
        {
            //a = qn +r Euclidean Algorithm 
            int r = 1;
            int a;
            int q;

            //check the input if x is > y then swap and assgin a and b
            if (x > y)
            {
                a = x;
                q = y;
            }
            else
            {
                a = y;
                q = x;
            }
            while (r > 0) // while the remainder is not zero the loop continue
            {
                r = a % q; // find the remainder
                a = q; // assgin a to q
                q = r; // assgin q to r use for the next calculation
            }
            //at then end return the result
            //return "The greatest common divisor of " + x +" and "+ y + " is " + a;
            return a;
        }

        public static int ExtendedEuclidean(int x, int m)
        {
            //pi = pi-2 - pi-1(qi-2) mod n 
            // n is the input m
            int p = 0; // p0 stpe 0
            int nextP = 1; // stpe 1
            // a = qn + r
            int a = m; // Use for Euclidean a
            int b = x; // Use for Euclidean q
            int r = 1; // remainder for the while loop
            //start at step 2 and while the remainder is not zero the loop continue
            while (r > 0)
            {
                int q = a / b; //find the q
                r = a % b; // find the reminder
                int pi = mod((p - (nextP * q)), m); // find the pi
                p = nextP; // assgin p to nextp and use to slove pi
                nextP = pi; // assgin nextP to pi and use to slove pi
                a = b; // reassgin a
                b = r; // reassgin b
                if (b == 1) // when b is == 1 then the result is found
                {
                    //return "The inverse of " + x + " and " + m + " is " + nextP;
                    return nextP;
                }
            }
            if (a > 1) // if the r minder is less than zero and b is not equal to one then that mean this problem have no inverse
            {
                //return "No inverse found";
                return 0;
            }
            //return "Error"; 
            return 0;
        }

        //find Modular
        static public int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
        static public long mod(long x, long m)
        {
            return ((x % m + m) % m);
        }

        static public int square(int number, int exponent, int modulo)
        {
            long result = mod(number, modulo);
            string binary = Convert.ToString(exponent, 2); // get the binary to the string
            //Console.WriteLine("binary number:{0}, length is {1}",binary,binary.Length);
            for (int i = 1; i < binary.Length; i++)
            {
                if (binary[i].ToString() == "1") 
                {
                    result = mod(((result * result) * number), modulo);
                }
                else
                {
                    result = mod((result * result), modulo);
                }
            }
            int finalresult = (int)result;
            return finalresult;
        }
        static public int GeneratePrimes(int n, bool notE)
        {
            //create a query list that is prime
            var r = from i in Enumerable.Range(1, n - 1).AsParallel()
                    where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || (i % j) != 0)
                    select i;
            Random random = new Random();
            var result = r.ToList();
            result.Sort();
            int finalresult;
            if (notE == false) // is p or q value get the greatest value
            {
                finalresult = result.Last();
            }
            else
            {
                //check for coprime of e and phin
                finalresult = result[random.Next(0, result.Count())];
                if (Euclidean(finalresult, n) == 1)
                {
                    return finalresult;
                }
                else
                {
                    while (true)
                    {
                        finalresult = result[random.Next(0, result.Count())];
                        if (Euclidean(finalresult, n) == 1)
                            break;
                    }
                }
            }

            return finalresult;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RSAForm());
        }
    }
}
