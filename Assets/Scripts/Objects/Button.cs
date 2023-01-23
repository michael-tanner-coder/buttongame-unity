using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameEvents gameEvents;

    void ActivateDoor()
    {
        gameEvents.activateDoorEvent?.Invoke();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "trigger") 
        {
            ActivateDoor();
        }
    }
}
