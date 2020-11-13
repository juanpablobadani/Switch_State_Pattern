using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface ISwitchState
    {
        void HandleOperation(Switch sw);
        string Define();
    }
}
