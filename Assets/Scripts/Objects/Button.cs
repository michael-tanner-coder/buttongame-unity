using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameEvents gameEvents;
    private ButtonState.Enums _state;

    void ActivateDoor()
    {
        gameEvents.activateDoorEvent?.Invoke();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "trigger") 
        {
            ActivateDoor();
            _state = ButtonState.Enums.PRESSED;
        }
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.tag == "trigger") 
        {
            _state = ButtonState.Enums.RELEASED;
        }
    }
}
