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


            //GenericMaximum genericMaximum = new GenericMaximum();

            //Console.WriteLine(genericMaximum.GetMaximun<int>(10, 20, 30));
            //Console.WriteLine(genericMaximum.GetMaximun<double>(10.5, 20.9, 30.7));
            //Console.WriteLine(genericMaximum.GetMaximun<string>("10", "20", "50"));



            //Console.WriteLine(new GenericMaximum<int>(10, 20, 30).GetMaximun());
            //Console.WriteLine(new GenericMaximum<double>(10.5, 2.0, 3.0).GetMaximun());
            //Console.WriteLine(new GenericMaximum<string>("48", "39", "93").GetMaximun());


            int[] arr = { 1, 3, 4, 6, 8 };
            double[] arr1 = { 1.0, 3.5, 40.0, 6.9, 0.8 };
            string[] arr2 = { "39", "29", "38", "32", "98" };

            Console.WriteLine(new GenericMaximum<int>(arr).MaxMethod());
            Console.WriteLine(new GenericMaximum<double>(arr1).MaxMethod());
            Console.WriteLine(new GenericMaximum<string>(arr2).MaxMethod());
        }
    }
}