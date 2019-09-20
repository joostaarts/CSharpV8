using System;

namespace CSharp.V8.ReadonlyStructMembers
{
    public struct ReadonlyStructMember
    {
        public int X { get; set; }

        public readonly string XValue => X.ToString();

        public readonly void PrintX()
        {
            // Not allowed
            // X = 1;

            Console.WriteLine(XValue);
        }
    }
}