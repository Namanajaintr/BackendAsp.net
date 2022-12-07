using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//D Dependency injection principle (DIP)

namespace PrinciplesOfCoding
{
    class DIP
    {
        //public class Email
        //{
        //    public void SendEmail() {
        //        // code to send mail
        //    }
        //}

        //public class Notification
        //{
        //    private Email _email;
        //    public Notification() {
        //        _email = new Email();
        //    }

        //    public void PromotionalNotification() {
        //        _email.SendEmail();
        //    }
        //}

        public interface IMessenger
        {
            void SendMessage();
        }
        public class Email : IMessenger
        {
            public void SendMessage() {
                // code to send email
            }
        }

        public class SMS : IMessenger
        {
            public void SendMessage() {
                // code to send SMS
            }
        }
        public class Notification
        {
            private IMessenger _iMessenger;
            public Notification() {
                _iMessenger = new Email();
            }
            public void DoNotify() {
                _iMessenger.SendMessage();
            }
        }

        //Still Notification class depends on Email class.
        //Now, we can use dependency injection so that we can make it loosely coupled.
        //There are 3 types to DI, Constructor injection, Property injection and method injection.

       // //Constructor Injection

       // public class Notification
       // {
       //     private IMessenger _iMessenger;
       //     public Notification(Imessenger pMessenger) {
       //         _iMessenger = pMessenger;
       //     }
       //     public void DoNotify() {
       //         _iMessenger.SendMessage();
       //     }
       // }

       // //Property Injection

       // public class Notification
       // {
       //     private IMessenger _iMessenger;
       //     public Notification() {
       //     }
       //     public IMessenger MessageService {
       //         private get;
       //         set {
       //             _iMessenger = value;
       //         }
       //     }
       //     public void DoNotify() {
       //         _iMessenger.SendMessage();
       //     }
       // }

       //// Method Injection

       // public class Notification
       // {
       //     public void DoNotify(IMessenger pMessenger) {
       //         pMessenger.SendMessage();
       //     }
       // }

    }
}
