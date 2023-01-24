using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameEvents gameEvents;
    private ButtonState.Enums _state;

    void ActivateDoor()
    {
        Debug.Log("Activating door");
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
            Debug.Log("Collision exit");
            _state = ButtonState.Enums.RELEASED;
        }
    }
}
