using System;

namespace CSharp.V7
{
    class Deconstruction
    {
        public static void Demo()
        {
            var (x, y, z) = GetXyz();
            Console.WriteLine($"{x} - {y} - {z}");

            var o = new Deconstructable();
            (x, y) = o;
            Console.WriteLine($"{x} - {y}");
        }

        public static (int, string, bool) GetXyz()
        {
            return (1, "2", false);
        }
    }
}