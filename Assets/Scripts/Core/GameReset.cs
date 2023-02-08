using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameReset : MonoBehaviour
{
    [SerializeField]
    private List<PlayerData> players;

    [SerializeField]
    private StateVariable _gameState;


    [SerializeField]
    private GameEvent _matchStart;

    void Awake()
    {
        ResetPlayerData();
    }

    void ResetPlayerData()
    {
        players.ForEach((PlayerData player) =>
        {
            player.ResetData();
        });
    }

    public void ResetGame()
    {
        Debug.Log("TRYING RESET GAME");
        if (_gameState.Value.Type == State.MATCH_END)
        {
            Debug.Log("RESETING GAME");
            ResetPlayerData();
            _matchStart?.Raise();
        }
    }
}






