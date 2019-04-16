using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Class_8.classes
{
    public delegate void MessageEventHandler(string message);
    public class Publisher
    {
        public event MessageEventHandler EventHandler;

        public void ComposeMessage(string trainerName, int groupNumber,string message)
        {

            Thread.Sleep(3000);

            SendMessage($"{ trainerName}informs G{ groupNumber}: { message}");
        }

        protected virtual void SendMessage(string message)
        {
            EventHandler?.Invoke(message);
        }
    }
}
