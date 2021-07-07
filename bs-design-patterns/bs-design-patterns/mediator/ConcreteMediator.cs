using System.Linq;

namespace bs_design_patterns.mediator
{
    class ConcreteMediator : Mediator
    {
        public override T CreateColleague<T>()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
            return colleague;
        }
        public override void SendMessage(Colleague sender, string msg)
        {
            var receivers = this.colleagues.Where(x => x != sender);

            foreach(var receiver in receivers)
            {
                receiver.Receive(msg);
            }
        }
    }
}
