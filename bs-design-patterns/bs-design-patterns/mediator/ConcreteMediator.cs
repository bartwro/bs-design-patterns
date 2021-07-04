using System.Linq;

namespace bs_design_patterns.mediator
{
    class ConcreteMediator : Mediator
    {
        internal override void SendMessage(Colleague sender, string msg)
        {
            var receivers = this.colleagues.Where(x => x != sender);

            foreach(var receiver in receivers)
            {
                receiver.HandleNotification(msg);
            }
        }
    }
}
