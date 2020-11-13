using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Switch
    {
        private ISwitchState _state;

        public Switch()
        {
            _state = new turnOn();
        }

        public void SetSwitchState(ISwitchState state)
        {
            _state = state;
        }

        public void Press()
        {
            _state.HandleOperation(this);
            Console.WriteLine(_state.Define());
        }
    }
}
