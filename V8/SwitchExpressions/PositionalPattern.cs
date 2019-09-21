using System;
using CSharp.V7;

namespace CSharp.V8.SwitchExpressions
{
    public class PositionalPattern
    {
        public static void Demo()
        {
            var res = GetValue();
            Console.WriteLine(res);
        }

        public static string GetValue()
        {
            var d = new Deconstructable();

            var res = d switch
            {
                var (x, y) when (x == 1) && (y != "asd") => "x equals 1...",
                _ => throw new System.Exception()
            };

            return res;
        }

    }

}