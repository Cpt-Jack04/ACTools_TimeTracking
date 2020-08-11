using System;
using UnityEngine;
using UnityEngine.Events;

namespace ACTools.TimeTracking
{
    [AddComponentMenu("ACTools/Time Tracking/Timer")]
    [Serializable]
    public class TimerComponent : MonoBehaviour, ITrackTime
    {
        [SerializeField] protected Timer timer = new Timer();

        public bool TickOnStart => timer.TickOnStart;
        public bool Ticking => timer.Ticking;

        public float StartValue => timer.StartValue;
        public float CurrentValue => timer.CurrentValue;

        public UnityEvent OnFinished => timer.OnFinished;

        protected virtual void Awake()
        {
            ResetValue();
        }

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

        /// <summary> Sets this Timer's startValue to a give float. </summary>
        /// <param name="newStartValue"> The new value for startTimer. If this value is less than zero, start value will be set to zero instead. </param>
        public virtual void SetStartValue(float newStartValue)
        {
            timer.SetStartValue(newStartValue);
        }

        /// <summary> Tells this Timer to start ticking. </summary>
        public virtual void StartTicking()
        {
            timer.StartTicking();
        }

        /// <summary> Preforms the operation for this Timer to tick once. </summary>
        public virtual void Tick()
        {
            timer.Tick();
        }

        /// <summary> Tells this Timer to stop ticking. </summary>
        public virtual void StopTicking()
        {
            timer.StopTicking();
        }

        /// <summary> Resets this Timer's currentValue to startValue. </summary>
        public virtual void ResetValue()
        {
            timer.ResetValue();
        }
    }
}