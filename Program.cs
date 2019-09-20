using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                V8.DefaultInterfaceMembers.ClassWithDefaultImpl.Demo();
                V8.SwitchExpressions.SwitchExpression.Demo();
                V8.SwitchExpressions.TuplePattern.Demo();

                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
