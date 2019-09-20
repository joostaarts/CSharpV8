using System;

namespace CSharp.V8.SwitchExpressions
{
    public class TuplePattern
    {
        public static void Demo()
        {
            Console.WriteLine($"Tuple Pattern: {GetValue(0, 0)}");
            Console.WriteLine($"Tuple Pattern: {GetValue(2, 0)}");
            Console.WriteLine($"Tuple Pattern: {GetValue(123, 123)}");
        }

        private static string GetValue(int x, int y)
        {
            var result = (x, y) switch
            {
                (0, 0) => "zero comma zero",
                (1, 1) => "een comma een",
                (2, _) => "two comma whatever",
                _ => "??"
            };

            return result;
        }
    }
}