using System;

namespace ECS.Legacy
{
    public class ECSControl
    {
        private int _threshold;
        private ITempSensor _tempSensor;
        private IHeater _heater;

        
        public ITempSensor TempSensor { get => _tempSensor; set => _tempSensor = value; }
        public IHeater Heater { get => _heater; set => _heater = value; }

        //Specifik Constructor for test
        public ECSControl(int thr,ITempSensor tempSensor,IHeater heater)
        {
            SetThreshold(thr);
            _tempSensor = tempSensor;
            _heater = heater;
        }


        //Standard produktion code
            public ECSControl(int thr)
        {
            SetThreshold(thr);
            _tempSensor = new TempSensor();
            _heater = new Heater();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
