using System;

namespace bs_design_patterns.mediator
{
    abstract class Colleague
    {
        private Mediator mediator;

        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void SendMessage(string msg)
        {
            this.mediator.SendMessage(this, msg);
        }

        internal void HandleNotification(string msg)
        {
            Console.WriteLine($"I got message: {msg}");
        }
    }
}
