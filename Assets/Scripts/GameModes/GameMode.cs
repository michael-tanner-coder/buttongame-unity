using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameMode", menuName = "Scriptable Objects/GameMode", order = 0)]
public class GameMode : ScriptableObject 
{
    public new string name;
    public float baseDuration;
    public bool limitButtonPresses;
    public float gravityModifier = 1f;
}