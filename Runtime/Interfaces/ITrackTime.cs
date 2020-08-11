using System;
using UnityEngine.Events;

namespace ACTools.TimeTracking
{
    public interface ITrackTime
    {
        bool TickOnStart { get; }
        bool Ticking { get; }

        float StartValue { get; }
        float CurrentValue { get; }

        void StartTicking();
        void Tick();
        void StopTicking();
        void ResetValue();
    }
}