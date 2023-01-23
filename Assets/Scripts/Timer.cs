using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameEvents gameEvents;


    void Start() 
    {
        StartTimer();
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
            gameEvents.roundEndEvent?.Invoke();         
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
        // Debug.Log("Timer complete");
    }
}
