using System;

namespace CSharp.V8.DefaultInterfaceMembers
{
    public interface IDefaultInterfaceMember
    {
        void MustBeImplemented();

        void DefaultImplemented()
        {
            Console.WriteLine("Default Implemented!");            
        }

    }

}