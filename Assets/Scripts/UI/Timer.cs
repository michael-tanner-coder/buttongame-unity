using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float _duration;
    private float _currentTime;
    private bool _finished;
    [SerializeField]
    private bool _paused = false;
    private float _progress;

    // UI element 
    [SerializeField]
    private Fill timerBar;

    // Events
    public GameEvents gameEvents;


    void Start() 
    {
        StartTimer();
    }
    void Update()
    {
        // return early if paused
        if (_paused) 
        {
            return;
        }
        
        // decrement timer
        _currentTime -= 1f * Time.deltaTime;
        _currentTime = Mathf.Clamp(_currentTime, 0f, _duration);

        // update UI
        _progress = Mathf.InverseLerp(0, _duration, _currentTime);
        timerBar.SetPercentage(_progress);

        // check if timer is _finished and invoke event
        if (_currentTime <= 0f && !_finished)
        {
            _finished = true;   
            gameEvents.roundEndEvent?.Invoke();
            OnComplete();
        }
    }

    public float GetProgress() 
    {
        return _progress;
    }

    void OnComplete() 
    {
        // Debug.Log("Timer complete");
    }

    void StartTimer() 
    {
        _finished = false;
        _paused = false;
        _currentTime = _duration;
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
        _currentTime = _duration;
    }
}
