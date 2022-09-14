using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}