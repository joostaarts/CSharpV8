namespace CSharp.V7
{
    public class Deconstructable
    {
        public int X { get; set; } = 1;
        public string Y { get; set; } = "To be deconstructed";

        public void Deconstruct(out int x, out string y)
        {
            (x, y) = (X, Y);
        }
    }

}