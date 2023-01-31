using UnityEngine;
using ScriptableObjectArchitecture;

public class GameStateTracker : MonoBehaviour
{
    [SerializeField]
    private StateReference _state;
    public StateReference State => _state;

    public void SetState(GameState gameState) 
    {
        _state.Value = gameState;
    }
}
