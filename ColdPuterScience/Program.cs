using System;

namespace ColdPuterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cold-Puter Science
            // https://open.kattis.com/problems/cold 
            // number of negative tempretures

            var samplesNum = EnterNumber();
            var samples = EnterTempretures(samplesNum);

            Console.WriteLine(BelowZeroNum(samples));
        }

        private static int BelowZeroNum(int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    num = num + 1;
            }
            return num;
        }
        private static int[] EnterTempretures(int num)
        {
            string[] arr = new string[num];
            int[] res = new int[num];

            try
            {
                arr = Console.ReadLine().Split(' ', num);
                for (int k = 0; k < arr.Length; k++)
                {
                    res[k] = int.Parse(arr[k]);
                    if (SampleCheck(res[k]) == false)
                        throw new ArgumentException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString() + ": " + ex.Message);
                return EnterTempretures(num);
            }
            return res;
        }

        private static int EnterNumber()
        {
            string str = "";
            int a = 0;
            str = Console.ReadLine();
            try
            {
                a = int.Parse(str);
                if (a < 1 || a > 100)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString()+": "+ex.Message);
                return EnterNumber();
            }
            return a;
        }
        private static bool SampleCheck(int a)
        {
            if (Math.Abs(a) <= 1000000)
                return true;
            else
                return false;
        }
    }
}
