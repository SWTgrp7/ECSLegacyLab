using System.Reflection;
using ECS.Legacy;
namespace ECS.Test.Unit
{
    public class ECS_Tests
    {
        private ECSControl uut;
        private IHeater _fakeHeater;
        private ITempSensor _fakeSensor;

        [SetUp]
        public void Setup()
        {
            _fakeHeater = new FakeHeater();
            _fakeSensor = new FakeTempSensor();
            //hvis vi vil bruge construktor til at lave fakes
            uut = new ECSControl(25,_fakeSensor,_fakeHeater);

            //hvis vi vil bruge properties.
            uut.TempSensor = _fakeSensor;
            uut.Heater = _fakeHeater;  
        }


        [TestCase(10)]
        [TestCase(40)]
        [TestCase(-20)]
        public void TestSetThresHold(int number1)
        {
            uut.SetThreshold(number1);
            Assert.That(number1,Is.EqualTo(uut.GetThreshold()));
            
        }


        [Test]
        public void TestRegulateLowTemp()
        {
            //threshold == 25
            
        }

        [TestCase(11)]
        [TestCase(25)]
        [TestCase(37)]
        public void TestGetThreshold(int threshold)
        {
            uut.SetThreshold(threshold);
            Assert.That(threshold, Is.EqualTo(uut.GetThreshold()));
        }


        [TestCase(20)]
        [TestCase(25)]
        [TestCase(37)]
        public void TestGetCurTemp(int temp)
        {
           // Assert.That();
        }

    }
}