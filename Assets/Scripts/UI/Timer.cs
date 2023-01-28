using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private ScriptableObjectArchitecture.FloatReference _duration;
    [SerializeField]
    private ScriptableObjectArchitecture.FloatReference _maxDuration;
    private bool _finished;
    [SerializeField]
    private bool _paused = true;

    // Events
    [SerializeField]
    private ScriptableObjectArchitecture.GameEvent onRoundEnd;


    void Awake() 
    {
        _duration.Value = _maxDuration.Value;
    }
    void Update()
    {
        // return early if paused
        if (_paused) 
        {
            return;
        }
        
        // decrement timer
        _duration.Value -= 1f * Time.deltaTime;

        // check if timer is _finished and invoke event
        if (_duration.Value <= 0f && !_finished)
        {
            _finished = true;   
            onRoundEnd.Raise();
        }
    }

    public void StartTimer() 
    {
        Debug.Log("Timer started");
        Reset();
        Play();
    }
    public void StopTimer() 
    {
        Debug.Log("Timer stopped");
        Reset();
        Pause();
    }

    public void Play() 
    {
        _paused = false;
    }

    public void Pause() 
    {
        _paused = true;
    }

    public void Reset() 
    {
        _finished = false;
        _duration.Value = _maxDuration.Value;
    }
}
