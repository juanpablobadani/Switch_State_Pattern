using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class turnOn : ISwitchState
    {
        public void HandleOperation(Switch sw)
        {
            sw.SetSwitchState(new turnOff());
        }

        public string Define()
        {
            return "Switch is on";
        }
    }
}
