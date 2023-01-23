using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private DoorState.Enums _state;

    void Update() {
        if (_state == DoorState.Enums.OPEN) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (_state == DoorState.Enums.CLOSED) {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
