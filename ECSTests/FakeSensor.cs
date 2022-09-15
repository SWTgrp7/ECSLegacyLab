using System;

namespace ECS.Legacy

{
    
    internal class FakeTempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return 20;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}