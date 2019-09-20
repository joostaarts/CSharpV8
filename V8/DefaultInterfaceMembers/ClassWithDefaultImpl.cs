using System;

namespace CSharp.V8.DefaultInterfaceMembers
{
    public class ClassWithDefaultImpl : IDefaultInterfaceMember
    {
        public void MustBeImplemented()
        {
            Console.WriteLine("I have been implemented.");
        }

        public static void Demo()
        {
            IDefaultInterfaceMember def = new ClassWithDefaultImpl();
            def.MustBeImplemented();
            def.DefaultImplemented();
        }
    }

}