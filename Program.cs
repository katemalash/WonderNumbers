using System;

namespace WonderNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string [] ar = s.Split(' ');
            int l = Int32.Parse(ar[0]);
            long r = Int64.Parse(ar[1]);
            long x = (long)Math.Floor(Math.Sqrt(l - 1)) + 1;
            long y = (long)Math.Floor(Math.Sqrt(r)) + 1;
            int count = 0;
            for (long i = x; i < y; i++)
            {
                long a = i * i;
                if (!IsSimple(a))
                {
                    if (IsSimple(DivCount(a)))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static long DivCount(long s)
        {
            long f = 2;
            for (int i = 2; i <= s / 2 + 1; i++)
            {
                if (s % i == 0)
                {
                    f++;
                }
            }
            return f;
        }
        public static bool IsSimple(long s)
        {
            bool d = false;
            long f = 2;
            while ((!d) && (f <= Math.Sqrt(s)))
            {
                if (s % f == 0)
                {
                    return false;
                }
                else
                {
                    f++;
                }
            }
            return true;  
        }   
    }
}
