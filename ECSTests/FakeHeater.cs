namespace ECS.Legacy
{
    

    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("CopyOfHeater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("CopyOfHeater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}