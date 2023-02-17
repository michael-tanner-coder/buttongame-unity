using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameReset : MonoBehaviour
{
    [SerializeField] private List<PlayerData> players;
    [SerializeField] private PlayerDataVariable _winner;
    [SerializeField] private PlayerData _defaultWinnerValue;

    void Awake()
    {
        ResetGame();
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
        ResetPlayerData();
        _winner.Value = _defaultWinnerValue;
    }
}






