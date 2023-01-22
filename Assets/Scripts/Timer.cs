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

    void Start() 
    {
        StartTimer();
    }

    void StartTimer() 
    {
        currentTime = duration;
    }

    void Update()
    {
        currentTime -= 1f * Time.deltaTime;

        if (currentTime <= 0f)
        {
            finished = true;
            currentTime = 0f;
        }

        progress = Mathf.InverseLerp(0, duration, currentTime);

        // update UI
        timerBar.SetPercentage(progress);

    }

    public float GetProgress() 
    {
        return progress;
    }
}
