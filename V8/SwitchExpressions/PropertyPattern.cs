using System;

namespace CSharp.V8.SwitchExpressions
{
    class PropertyPattern
    {
        public static void Demo()
        {
            var o = new Test
            {
                X = 1,
                Y = TestEnum.B
            };
            Console.WriteLine(GetValeu(o));

            o.X = 2;
            o.Y = TestEnum.C;
            Console.WriteLine(GetValeu(o));
        }

        private static string GetValeu(Test o)
        {
            var val = o switch
            {
                { X: 1 } => "One",
                { Y: TestEnum.B } => "B",
                { X: _, Y: TestEnum.C } => "2C",
                _ => "oh no"
            };

            return val;
        }

        class Test
        {
            public int X { get; set; }
            public TestEnum Y { get; set; }
        }

    }
}