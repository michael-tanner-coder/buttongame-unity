using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float duration;
    private float currentTime;
    private bool finished;
    private float progress;

    // UI element 
    [SerializeField]
    private Fill timerBar;

    // Events
    private UnityEvent _timerFinished;

    void Start() 
    {
        StartTimer();

        if (_timerFinished == null)
            _timerFinished = new UnityEvent();
            
        _timerFinished.AddListener(TimerComplete);
    }

    void StartTimer() 
    {
        finished = false;
        currentTime = duration;
    }

    void Update()
    {
        // decrement timer
        currentTime -= 1f * Time.deltaTime;
        currentTime = Mathf.Clamp(currentTime, 0f, duration);

        // check if timer is finished and invoke event
        if (currentTime <= 0f && !finished)
        {
            finished = true;   
            _timerFinished.Invoke();         
        }

        // update UI
        progress = Mathf.InverseLerp(0, duration, currentTime);
        timerBar.SetPercentage(progress);
    }

    public float GetProgress() 
    {
        return progress;
    }

    void TimerComplete() 
    { 
        Debug.Log("Timer complete");
    }
}
