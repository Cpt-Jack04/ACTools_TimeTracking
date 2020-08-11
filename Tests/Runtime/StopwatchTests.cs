using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace ACTools.TimeTracking.Tests.PlayMode
{
    public class StopwatchTests
    {
        [UnityTest]
        public IEnumerator Tick_WhenTicking_IncreaseByDeltaTime()
        {
            GameObject gameObject = new GameObject();
            StopwatchComponent testStopwatch = gameObject.AddComponent<StopwatchComponent>();
            testStopwatch.StartTicking();

            yield return null;

            Assert.AreEqual(Time.deltaTime, testStopwatch.CurrentValue, 0.0000001f);
        }
    }
}