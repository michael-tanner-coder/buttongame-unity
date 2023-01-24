using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GameEvents", menuName = "Scriptable Objects/GameEvents", order = 0)]
public class GameEvents : ScriptableObject 
{
    [System.NonSerialized]
    public UnityEvent roundEndEvent;

    [System.NonSerialized]
    public UnityEvent roundStartEvent;

    [System.NonSerialized]
    public UnityEvent activateDoorEvent;

    private void OnEnable() 
    {
        if (roundStartEvent == null)
            roundStartEvent = new UnityEvent();

        if (roundEndEvent == null)
            roundEndEvent = new UnityEvent();

        if (activateDoorEvent == null)
            activateDoorEvent = new UnityEvent();
    }
}
