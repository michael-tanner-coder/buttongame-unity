using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject 
{
    public int score;
    public DoorStates.Enums doorState;

    void ResetData() 
    { 
        score = 0; 
        doorState = DoorStates.Enums.OPEN; 
    }
}

