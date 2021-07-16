using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.command
{
    interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
