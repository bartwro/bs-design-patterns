using System;
using System.Collections.Generic;
using System.Text;
using static bs_design_patterns.memento.Memento;

namespace bs_design_patterns.memento
{
    class Context
    {
        static public void Run()
        {
            var orig = new Originator();
            orig._state = "state1";
            var backup1 = orig.CreateBackup();
            orig._state = "state2";
            orig._state = "state3";
            var backup2 = orig.CreateBackup();
            orig._state = "state4";
            orig._state = "state5";
            orig.Restore(backup2);
            Console.WriteLine((string)orig._state);
            orig.Restore(backup1);
            Console.WriteLine((string)orig._state);
        }
    }
}
