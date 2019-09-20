using System;

namespace CSharp.V8.SwitchExpressions
{
    public class SwitchExpression
    {
        public static void Demo()
        {
            Console.WriteLine($"Switch expression: {GetValue(0)}");
        }

        public static string GetValue(int x)
        {
            var value = x switch
            {
                0 => "zero",
                _ => throw new System.Exception("Invalid input")
            };

            return value;
        }

    }
}