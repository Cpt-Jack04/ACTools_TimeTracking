using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace ACTools.TimeTracking.Tests.PlayMode
{
    public class TimerTests
    {
        [UnityTest]
        public IEnumerator Tick_WhenTicking_DecreaseByDeltaTime()
        {
            GameObject gameObject = new GameObject();
            TimerComponent testTimer = gameObject.AddComponent<TimerComponent>();
            testTimer.SetStartValue(1f);
            testTimer.ResetValue();
            testTimer.StartTicking();

            yield return null;

            Assert.AreEqual(Time.deltaTime, testTimer.StartValue - testTimer.CurrentValue, 0.0000001f);
        }
    }
}