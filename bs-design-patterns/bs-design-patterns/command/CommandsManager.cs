using System.Collections.Generic;
using System.Linq;

namespace bs_design_patterns.command
{
    class CommandsManager
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if(command.CanExecute())
            {
                command.Execute();
                this.commands.Push(command);
            }
        }

        public void Undo()
        {
            if(this.commands.Any())
            {
                this.commands.Pop().Undo();
            }
        }
    }
}
