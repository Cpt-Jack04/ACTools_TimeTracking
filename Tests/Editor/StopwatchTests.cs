using NUnit.Framework;

namespace ACTools.TimeTracking.Tests.EditMode
{
    public class StopwatchTests
    {
        [Test]
        public void ResetValid_WhenCalled_SetCurrentValueToStartValue()
        {
            Stopwatch testStopwatch = new Stopwatch();
            testStopwatch.ResetValue();

            Assert.AreEqual(testStopwatch.StartValue, testStopwatch.CurrentValue);
        }
    }
}