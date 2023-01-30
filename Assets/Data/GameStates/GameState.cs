using UnityEngine;


[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/GameState", order = 0)]


public class GameState : ScriptableObject 
{
    public new string name;

    [SerializeField]
    private State _type;

    public State Type => _type;
}

