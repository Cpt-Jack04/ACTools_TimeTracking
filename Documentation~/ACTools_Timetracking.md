# ACTools: Timetracking

## Interfaces

### ITrackTime
<br>
<ul>
	<li><b>Properties:<b></li>
	<ul>
		<li>
			<p>bool TickOnStart { get; }</p>
			<p>Should this ITrackTime begin counting during void Start()?</p>
		</li>
		<li>
			<p>bool Ticking { get; }</p>
			<p>Is this ITrackTime currently ticking?</p>
		</li>
		<li>
			<p>float StartValue { get; }</p>
			<p>The value this ITrackTime starts at.</p>
		</li>
		<li>
			<p>float CurrentValue { get; }</p>
			<p>The value this ITrackTime at this time.</p>
		</li>
	</ul>
	<li><b>Methods:<b></li>
	<ul>
		<li>
			<p>void StartTicking();</p>
			<p>Tells this ITrackTime to start ticking.</p>
		</li>
		<li>
			<p>void Tick();</p>
			<p>Preforms the operation for this ITrackTime to tick once.</p>
		</li>
		<li>
			<p>void StopTicking();</p>
			<p>Tells this ITrackTime to stop ticking.</p>
		</li>
		<li>
			<p>void StopTicking();</p>
			<p>Tells this ITrackTime to stop ticking.</p>
		</li>
		<li>
			<p>void ResetValue();</p>
			<p>Resets this ITrackTime's CurrentValue to StartValue.</p>
		</li>
	</ul>
</ul>
<hr/>

## C# Objects

### public class Stopwatch : ITrackTime
<br>
<ul>
	<li><b>Constructors:<b></li>
	<ul>
		<li>
			<p>public Stopwatch()</p>
			<p>Creates a Stopwatch with default values.</p>
		</li>
		<li>
			<p>public Stopwatch(bool shouldTickOnStart)</p>
			<p>Creates a Stopwatch where bool tickOnStart equals shouldTickOnStart.</p>
		</li>
	</ul>
	<li><b>Fields:<b></li>
	<ul>
		<li>
			<p>protected bool tickOnStart</p>
			<p>
				Should this Stopwatch begin counting during void Start()?
				<br/>
				If this Stopwatch is in a custom script, you will need to tell it to use void StartTicking() in void Start().
			</p>
		</li>
		<li>
			<p>protected float currentValue</p>
			<p>This is the current value of this Stopwatch. It is a read only field within the inspector.</p>
		</li>
	</ul>
	<li><b>Properties:<b></li>
	<ul>
		<li>
			<p>public bool TickOnStart { get; }</p>
			<p>Should this Stopwatch begin counting during void Start()?</p>
		</li>
		<li>
			<p>public bool Ticking { get; protected set; }</p>
			<p>Is this Stopwatch currently ticking?</p>
		</li>
		<li>
			<p>public float StartValue { get; }</p>
			<p>Returns zero.</p>
		</li>
		<li>
			<p>public float CurrentValue { get; }</p>
			<p>The value this Stopwatch at this time.</p>
		</li>
	</ul>
	<li><b>Methods:<b></li>
	<ul>
		<li>
			<p>public virtual void StartTicking();</p>
			<p>Tells this Stopwatch to start ticking.</p>
		</li>
		<li>
			<p>public virtual void Tick();</p>
			<p>Preforms the operation for this Stopwatch to tick once.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Stopwatch to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Stopwatch to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void ResetValue();</p>
			<p>Resets this Stopwatch's CurrentValue to StartValue.</p>
		</li>
	</ul>
</ul>

### public class Timer : ITrackTime
<br>
<ul>
	<li><b>Constructors:<b></li>
	<ul>
		<li>
			<p>public Timer()</p>
			<p>Creates a Timer with default values.</p>
		</li>
		<li>
			<p>public Timer(float givenStartingValue)</p>
			<p>Creates a Timer where float startValue equals givenStartingValue.</p>
		</li>
		<li>
			<p>public Timer(bool shouldTickOnStart, float givenStartingValue)</p>
			<p>Creates a Timer where bool tickOnStart equals shouldTickOnStart and  where float startValue equals givenStartingValue.</p>
		</li>
	</ul>
	<li><b>Fields:<b></li>
	<ul>
		<li>
			<p>protected bool tickOnStart</p>
			<p>
				Should this Timer begin counting during void Start()?
				<br/>
				If this Timer is in a custom script, you will need to tell it to use void StartTicking() in void Start().
			</p>
		</li>
		<li>
			<p>protected float startValue</p>
			<p>his is the value this timer will start at when it begins ticking.</p>
		</li>
		<li>
			<p>protected float currentValue</p>
			<p>This is the current value of this Timer. It is a read only field within the inspector.</p>
		</li>
		<li>
			<p>public UnityEvent OnFinished</p>
			<p>This UnityEvent is invoked when this Timer's currentValue reaches a value of zero.</p>
		</li>
	</ul>
	<li><b>Properties:<b></li>
	<ul>
		<li>
			<p>public bool TickOnStart { get; }</p>
			<p>Should this Timer begin counting during void Start()?</p>
		</li>
		<li>
			<p>public bool Ticking { get; protected set; }</p>
			<p>Is this Timer currently ticking?</p>
		</li>
		<li>
			<p>public float StartValue { get; }</p>
			<p>The value this Timer starts at.</p>
		</li>
		<li>
			<p>public float CurrentValue { get; }</p>
			<p>The value this Timer at this time.</p>
		</li>
	</ul>
	<li><b>Methods:<b></li>
	<ul>
		<li>
			<p>public virtual void SetStartValue(float newStartValue)</p>
			<p>Sets this Timer's startValue to a give float.</p>
			<p>newStartValue: The new value for startTimer. If this value is less than zero, start value will be set to zero instead.</p>
		</li>
		<li>
			<p>public virtual void StartTicking();</p>
			<p>Tells this Timer to start ticking.</p>
		</li>
		<li>
			<p>public virtual void Tick();</p>
			<p>Preforms the operation for this Timer to tick once.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Timer to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Timer to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void ResetValue();</p>
			<p>Resets this Timer's CurrentValue to StartValue.</p>
		</li>
	</ul>
</ul>
<hr/>

## Monobehaviours

### public class StopwatchComponent : MonoBehaviour, ITrackTime
<br>
<ul>
	<li><b>Fields:<b></li>
	<ul>
		<li>
			<p>protected Stopwatch stopwatch</p>
			<p>This is the Stopwatch for this Monobehaviour.</p>
		</li>
	</ul>
	<li><b>Properties:<b></li>
	<ul>
		<li>
			<p>public bool TickOnStart { get; }</p>
			<p>Should this Stopwatch begin counting during void Start()?</p>
		</li>
		<li>
			<p>public bool Ticking { get; protected set; }</p>
			<p>Is this Stopwatch currently ticking?</p>
		</li>
		<li>
			<p>public float StartValue { get; }</p>
			<p>Returns zero.</p>
		</li>
		<li>
			<p>public float CurrentValue { get; }</p>
			<p>The value this Stopwatch at this time.</p>
		</li>
	</ul>
	<li><b>Methods:<b></li>
	<ul>
		<li>
			<p>public virtual void StartTicking();</p>
			<p>Tells this Stopwatch to start ticking.</p>
		</li>
		<li>
			<p>public virtual void Tick();</p>
			<p>Preforms the operation for this Stopwatch to tick once.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Stopwatch to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Stopwatch to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void ResetValue();</p>
			<p>Resets this Stopwatch's CurrentValue to StartValue.</p>
		</li>
	</ul>
</ul>

### public class TimerComponent : ITrackTime
<br>
<ul>
	<li><b>Fields:<b></li>
	<ul>
		<li>
			<p>protected Timer timer</p>
			<p>This is the Timer for this Monobehaviour.</p>
		</li>
	</ul>
	<li><b>Properties:<b></li>
	<ul>
		<li>
			<p>public bool TickOnStart { get; }</p>
			<p>Should this Timer begin counting during void Start()?</p>
		</li>
		<li>
			<p>public bool Ticking { get; protected set; }</p>
			<p>Is this Timer currently ticking?</p>
		</li>
		<li>
			<p>public float StartValue { get; }</p>
			<p>The value this Timer starts at.</p>
		</li>
		<li>
			<p>public float CurrentValue { get; }</p>
			<p>The value this Timer at this time.</p>
		</li>
	</ul>
	<li><b>Methods:<b></li>
	<ul>
		<li>
			<p>public virtual void SetStartValue(float newStartValue)</p>
			<p>Sets this Timer's startValue to a give float.</p>
			<p>newStartValue: The new value for startTimer. If this value is less than zero, start value will be set to zero instead.</p>
		</li>
		<li>
			<p>public virtual void StartTicking();</p>
			<p>Tells this Timer to start ticking.</p>
		</li>
		<li>
			<p>public virtual void Tick();</p>
			<p>Preforms the operation for this Timer to tick once.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Timer to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void StopTicking();</p>
			<p>Tells this Timer to stop ticking.</p>
		</li>
		<li>
			<p>public virtual void ResetValue();</p>
			<p>Resets this Timer's CurrentValue to StartValue.</p>
		</li>
	</ul>
</ul>
<hr/>
