using System;
using System.Collections.Generic;
using static bs_design_patterns.memento.Memento;

namespace bs_design_patterns.memento
{
    class Caretaker
    {
        Stack<Memento> _undoStack = new Stack<Memento>();
        Stack<Memento> _redoStack = new Stack<Memento>();
        private readonly Originator _orig;
        Memento _currentState;

        public Caretaker(Originator originator)
        {
            if(originator == null)
            {
                throw new ArgumentNullException(nameof(originator));
            }

            this._orig = originator;
            this._currentState = originator.CreateBackup();
        }

        public void ChangeOrig(string newValue)
        {
            this._orig._state = newValue;
            this._undoStack.Push(this._currentState);
            this._currentState = this._orig.CreateBackup();
        }

        public void Undo()
        {
            this._redoStack.Push(this._currentState);
            this._currentState = this._undoStack.Pop();
            this._orig.Restore(this._currentState);
        }

        public void Redo()
        {
            this._undoStack.Push(this._currentState);
            this._currentState = this._redoStack.Pop();
            this._orig.Restore(this._currentState);
        }
    }
}
