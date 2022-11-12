using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum_
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] values;


        public GenericMaximum(T[] values)
        {
            this.values = values;
            
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_Value = Sort(values);
            return sorted_Value[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.values);
            return max;
        }
        public void ToPrint()
        {
            var maximun = MaxValue(this.values);
            Console.WriteLine($"Maximum Value is: {maximun}");
        }
        
    }
}
