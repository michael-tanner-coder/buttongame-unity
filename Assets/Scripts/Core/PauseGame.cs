using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool _isPaused = false;

    public void TogglePause() 
    {
        if (_isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
        
        _isPaused = _isPaused ? false : true;
    }

    void Pause ()
    {
        Time.timeScale = 0;
    }
    void Resume ()
    {
        Time.timeScale = 1;
    }
}
