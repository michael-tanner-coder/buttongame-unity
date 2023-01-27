using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private DoorState _state;

    [SerializeField]
    private GameEvents _events;
    
    [SerializeField]
    private PlayerData _playerData;

    void Start() 
    {
        _events.activateDoorEvent.AddListener(Activate);
    }

    void Activate() 
    {
        _state = _state == DoorState.CLOSED ? DoorState.OPEN : DoorState.CLOSED;
        gameObject.GetComponent<SpriteRenderer>().enabled = _state == DoorState.CLOSED;
        _playerData.doorState = _state;
    }
}
