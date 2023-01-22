using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameMode", menuName = "Scriptable Objects/GameMode", order = 0)]
public class GameMode : ScriptableObject 
{
    public string name;
    public float baseDuration;
    public DoorStates.Enums winningState;
    public bool limitButtonPresses;
    public float gravityModifier = 1f;
}