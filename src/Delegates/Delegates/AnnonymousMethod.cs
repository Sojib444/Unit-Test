using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class AnnonymousMethod
    {


        public static void Invoke()
        {
            Func<int,int,int> sum = delegate(int n,int b) { return n; };
            int d=sum(1,2);
            Console.WriteLine(d);
        }

        public static void InvokeLabda()
        {
            Action<int,int> sum = (int n, int b) => Console.WriteLine("Hit this "+ n+b);
            sum(1, 2);
        }

    }
}
