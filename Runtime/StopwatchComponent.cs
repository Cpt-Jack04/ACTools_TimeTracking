using System;
using UnityEngine;

namespace ACTools.TimeTracking
{
    [AddComponentMenu("ACTools/Time Tracking/Stopwatch")]
    [Serializable]
    public class StopwatchComponent : MonoBehaviour, ITrackTime
    {
        [SerializeField] protected Stopwatch stopwatch = new Stopwatch();

        public bool TickOnStart => stopwatch.TickOnStart;
        public bool Ticking => stopwatch.Ticking;

        public float StartValue => stopwatch.StartValue;
        public float CurrentValue => stopwatch.CurrentValue;

        protected virtual void Start()
        {
            if (TickOnStart)
                StartTicking();
        }

        protected virtual void Update()
        {
            if (Ticking)
                Tick();
        }

        /// <summary> Tells this Stopwatch to start ticking. </summary>
        public virtual void StartTicking()
        {
            stopwatch.StartTicking();
        }

        /// <summary> Preforms the operation for this Stopwatch to tick once. </summary>
        public virtual void Tick()
        {
            stopwatch.Tick();
        }

        /// <summary> Tells this Stopwatch to stop ticking. </summary>
        public virtual void StopTicking()
        {
            stopwatch.StopTicking();
        }

        /// <summary> Resets this Stopwatch's currentValue to startValue. </summary>
        public virtual void ResetValue()
        {
            stopwatch.ResetValue();
        }
    }
}