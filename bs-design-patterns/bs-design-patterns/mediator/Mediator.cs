using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.mediator
{
    abstract class Mediator
    {
        protected List<Colleague> colleagues = new List<Colleague>();
        public abstract T CreateColleague<T>() where T : Colleague, new();

        public abstract void SendMessage(Colleague sender, string msg);
    }
}
