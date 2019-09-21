using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"V7");
                V7.Deconstruction.Demo();

                Console.WriteLine($"{Environment.NewLine}V8");
                V8.DefaultInterfaceMembers.ClassWithDefaultImpl.Demo();
                V8.SwitchExpressions.SwitchExpression.Demo();
                V8.SwitchExpressions.TuplePattern.Demo();
                V8.SwitchExpressions.PropertyPattern.Demo();
                V8.SwitchExpressions.PositionalPattern.Demo();

                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
