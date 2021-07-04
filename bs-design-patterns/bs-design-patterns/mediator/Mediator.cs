using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.mediator
{
    abstract class Mediator
    {
        protected List<Colleague> colleagues = new List<Colleague>();
        public T CreateColleague<T>() where T : Colleague, new()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
            return colleague;
        }

        internal abstract void SendMessage(Colleague sender, string msg);
    }
}
