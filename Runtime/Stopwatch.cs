using System;
using UnityEngine;

namespace ACTools.TimeTracking
{
    [Serializable]
    public class Stopwatch : ITrackTime
    {
        [Tooltip("Should this Stopwatch begin counting during void Start()?" +
                 "If this Stopwatch is in a custom script, you will need to tell it to use void StartTicking() in void Start().")]
        [SerializeField] protected bool tickOnStart = false;

        [Tooltip("This is the current value of this Stopwatch. It is a read only field within the inspector.")]
        [SerializeField, ReadOnly] protected float currentValue = 0f;

        public bool TickOnStart => tickOnStart;
        public bool Ticking { get; protected set; } = false;

        public float StartValue => 0f;
        public float CurrentValue => currentValue;

        public Stopwatch()
        {

        }

        public Stopwatch(bool shouldTickOnStart)
        {
            tickOnStart = shouldTickOnStart;
        }

        /// <summary> Tells this Stopwatch to start ticking. </summary>
        public virtual void StartTicking()
        {
            Ticking = true;
        }

        /// <summary> Preforms the operation for this Stopwatch to tick once. </summary>
        public virtual void Tick()
        {
            currentValue += Time.deltaTime;
        }

        /// <summary> Tells this Stopwatch to stop ticking. </summary>
        public virtual void StopTicking()
        {
            Ticking = false;
        }

        /// <summary> Resets this Stopwatch's currentValue to startValue. </summary>
        public virtual void ResetValue()
        {
            currentValue = StartValue;
        }
    }
}