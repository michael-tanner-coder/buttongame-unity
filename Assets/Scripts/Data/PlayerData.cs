using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject 
{
    public string playerName;
    public int score;
    public DoorState doorState;

    public void ResetData() 
    { 
        score = 0; 
        doorState = DoorState.OPEN; 
    }
}

