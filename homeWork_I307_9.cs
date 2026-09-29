using System;
using System.Linq;
namespace homework
{
    public class ClsMath
    {
        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Sum();
        }
        public int Max(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Max();
        }
        public int Min(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Min();
        }
        public int Count(int[] numbers)
        {
            return numbers?.Length ?? 0;
        }
    }
}