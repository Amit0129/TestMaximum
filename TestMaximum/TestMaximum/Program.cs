namespace TestMaximum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Test Program");

            //Console.WriteLine(MaximumNumberCheck.MaximumIntegerNumber(30, 30, 30));
            //Console.WriteLine(MaximumNumberCheck.MaximumFloatsNumber(30.4, 30.8, 30.9));
            //Console.WriteLine(MaximumNumberCheck.MaximumString("Amit", "Kumar", "Nayakk"));
            GenericMaximum genericMaximum = new GenericMaximum();
            Console.WriteLine(genericMaximum.GetMaximun<int>(10, 20, 30));
            Console.WriteLine(genericMaximum.GetMaximun<double>(10.5, 20.9, 30.7));
            Console.WriteLine(genericMaximum.GetMaximun<string>("10", "20", "50"));
            
        }
    }
}