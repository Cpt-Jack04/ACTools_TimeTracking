using System;
using UnityEngine;
using UnityEngine.Events;

namespace ACTools.TimeTracking
{
    [Serializable]
    public class Timer : ITrackTime
    {
        [Tooltip("Should this Timer begin counting during void Start()?" +
                 "If this Timer is in a custom script, you will need to tell it to use void StartTicking() in void Start().")]
        [SerializeField] protected bool tickOnStart = false;

        [Tooltip("This is the value this timer will start at when it begins ticking.")]
        [SerializeField, Min(0f)] protected float startValue = 0f;
        [Tooltip("This is the current value of this Timer. It is a read only field within the inspector.")]
        [SerializeField, ReadOnly] protected float currentValue = 0f;

        [Space]

        [Tooltip("This UnityEvent is invoked when this Timer's currentValue reaches a value of zero.")]
        public UnityEvent OnFinished;

        public bool TickOnStart => tickOnStart;
        public bool Ticking { get; protected set; } = false;

        public float StartValue => startValue;
        public float CurrentValue => currentValue;

        public Timer()
        {

        }

        public Timer(float givenStartingValue)
        {
            SetStartValue(givenStartingValue);
        }

        public Timer(bool shouldTickOnStart, float givenStartingValue)
        {
            tickOnStart = shouldTickOnStart;
            SetStartValue(givenStartingValue);
        }

        /// <summary> Sets this Timer's startValue to a give float. </summary>
        /// <param name="newStartValue"> The new value for startTimer. If this value is less than zero, start value will be set to zero instead. </param>
        public virtual void SetStartValue(float newStartValue)
        {
            startValue = newStartValue >= 0f ? newStartValue : 0f;
        }

        /// <summary> Tells this Timer to start ticking. </summary>
        public virtual void StartTicking()
        {
            Ticking = true;
        }

        /// <summary> Preforms the operation for this Timer to tick once. </summary>
        public virtual void Tick()
        {
            currentValue -= Time.deltaTime;
            if (currentValue <= 0f)
            {
                StopTicking();
                OnFinished?.Invoke();
            }
        }

        /// <summary> Tells this Timer to stop ticking. </summary>
        public virtual void StopTicking()
        {
            Ticking = false;
        }

        /// <summary> Resets this Timer's currentValue to startValue. </summary>
        public virtual void ResetValue()
        {
            currentValue = startValue;
        }
    }
}