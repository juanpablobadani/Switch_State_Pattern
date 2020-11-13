using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class loading : ISwitchState
    {
        public void HandleOperation(Switch sw)
        {
            sw.SetSwitchState(new turnOn());
        }

        public string Define()
        {
            return "Switch is loading";
        }
    }
}
