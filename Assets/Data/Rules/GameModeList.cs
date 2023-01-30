using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameModeList", menuName = "Scriptable Objects/GameModeList", order = 0)]
public class GameModeList : ScriptableObject 
{

    [SerializeField]
    private List<GameMode> _value;
    
    [HideInInspector]
    public List<GameMode> Value => _value;
}
