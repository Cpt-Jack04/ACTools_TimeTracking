using NUnit.Framework;

namespace ACTools.TimeTracking.Tests.EditMode
{
    public class TimerTests
    {
        [Test]
        public void SetStartValue_WhenValid_SetToGiven()
        {
            Timer testTimer = new Timer(1f);

            Assert.AreEqual(1f, testTimer.StartValue);
        }

        [Test]
        public void SetStartValue_WhenInvalid_SetToZero()
        {
            Timer testTimer = new Timer(-1f);

            Assert.AreEqual(0f, testTimer.StartValue);
        }

        [Test]
        public void ResetValid_WhenCalled_SetCurrentValueToStartValue()
        {
            Timer testTimer = new Timer(1f);
            testTimer.ResetValue();

            Assert.AreEqual(testTimer.StartValue, testTimer.CurrentValue);
        }
    }
}