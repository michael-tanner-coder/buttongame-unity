using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Scriptable Objects/GameEvent", order = 0)]
public class GameEvent : ScriptableObject 
{
    public string name;
    public float baseDuration;
    public DoorStates.Enums winningState;
    public bool limitButtonPresses;
    public float gravityModifier = 1f;
}