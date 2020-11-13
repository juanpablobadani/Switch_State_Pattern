using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class turnOff : ISwitchState
    {
        public void HandleOperation(Switch sw)
        {
            sw.SetSwitchState(new loading());
        }

        public string Define()
        {
            return "Switch is off";
        }
    }
}
