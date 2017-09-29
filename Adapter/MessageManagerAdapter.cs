using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MessageManagerAdapter : IMessenger
    {
        private readonly MessageManager _messageManager;

        public MessageManagerAdapter(MessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        public void Notify(string msg)
        {
            _messageManager.SendMessageInformation(msg);
        }
    }
}
