namespace Delegates
{
    public class DelegateExample
    {

        public delegate int Sum(int a, int b);


        public static void Invoke(Sum sum)
        {
            int d = sum(2, 4);
            Console.WriteLine(d);
        }



    }
}
