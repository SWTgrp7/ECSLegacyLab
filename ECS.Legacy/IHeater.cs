using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public interface IHeater
    {
        bool RunSelfTest();
        void TurnOff();
        void TurnOn();
    }
}