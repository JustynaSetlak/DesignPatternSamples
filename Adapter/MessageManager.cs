using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MessageManager
    {
        public void SendMessageInformation(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
