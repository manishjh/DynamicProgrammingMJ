using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 


namespace RodCutting
{
    class RodCutting
    {
        private int[] p = { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
        int cutRod(ref int[] p,int Length,ref List<int> r)
        {
            if(r[Length]>=0)
            {
                return r[Length];
            }
            if (Length == 0)
            {
                return 0;
            }
            int q = -9999;
            for (int i = 0; i < Length;i++)
            {
                q = Math.Max(q, p[i] + cutRod(ref p, Length - 1 -i,ref r));
            }
            r[Length] = q;
            return q; 
        }
        int cut_rod_dyn(int[] p,int Length)
        {
            List<int> r = new List<int>();
            for (int i = 0; i < Length + 1;i++ )
            {
                r.Add(-9999);
            }
                return cutRod(ref p, Length, ref r); 

        }
        static void Main(string[] args)
        {
            RodCutting rc = new RodCutting();
            int Length = Convert.ToInt16(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine(rc.cut_rod_dyn(rc.p,Length));
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds*10);
            Console.ReadKey();
        }
    }
}
