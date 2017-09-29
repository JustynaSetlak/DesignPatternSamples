using Adapter.Interface;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger messenger = new MessageManagerAdapter(new MessageManager());
            messenger.Notify("Message form messageManager!");

            Console.ReadKey();
        }
    }
}
