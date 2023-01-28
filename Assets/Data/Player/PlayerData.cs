using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject 
{
    public string playerName;
    public ScriptableObjectArchitecture.IntReference score;
    public ScriptableObjectArchitecture.IntReference maxScore;
    public DoorState doorState;
    

    public void ResetData() 
    { 
        score.Value = 0; 
        doorState = DoorState.OPEN; 
    }
}

