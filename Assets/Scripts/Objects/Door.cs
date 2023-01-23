using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private DoorState.Enums _state;

    [SerializeField]
    private GameEvents _events;

    void Start() 
    {
        _events.activateDoorEvent.AddListener(Activate);
    }

    void Activate() 
    {
        if (_state == DoorState.Enums.OPEN) 
        {
            _state = DoorState.Enums.CLOSED;
        } else 
        {
            _state = DoorState.Enums.OPEN;
        }
    }

    void Update() {
        if (_state == DoorState.Enums.OPEN) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (_state == DoorState.Enums.CLOSED) {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
