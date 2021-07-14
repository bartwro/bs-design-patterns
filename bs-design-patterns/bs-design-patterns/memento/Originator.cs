using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.memento
{
    /// <summary>
    /// Originator is an object whose state is being tracked, i.e. document, game, canvas, 
    /// </summary>
    public class Memento
        {
            private object _state;

            public Memento(object state)
            {
                this._state = state;
            }

            /// <summary>
            /// This is private, but since Originator is nested Memento class, Originator will see this private method
            /// </summary>
            /// <returns></returns>
            private object GetSavedState()
            {
                return this._state;
            }

            public class Originator
            {
                public object _state;

                public Memento CreateBackup()
                {
                    return new Memento(_state);
                }

                public void Restore(Memento memento)
                {
                    _state = memento.GetSavedState();
                }
            }
        }
}
