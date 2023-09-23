using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day3
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();

    }
    public interface IPayments
    {
        void MakePayment(float amount);
    }
    internal class Whatsapp : IMessageService,IPayments
    {
        public void SendMessage(string message)
        {
        Console.WriteLine("Message Sent");
        }
        public void DeleteMessage()
        {
            Console.WriteLine("Message Deleted");
        }
        public void MakePayment(float amount)
        {
            Console.WriteLine($"Paid Amount{amount}");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
    }
    //end of internal class whatsapp
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new Whatsapp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMessage();

        }
    }
}
