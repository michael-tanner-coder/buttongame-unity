using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GetWinner : MonoBehaviour
{
    [SerializeField] private List<PlayerData> players;
    [SerializeField] private PlayerDataVariable _winner;

    public void CheckForWinner()
    {
        UpdateScores();
        players.ForEach((player) =>
        {
            if (isMatchWinner(player))
            {
                _winner.Value = player;
            }
        });
    }

    void UpdateScores() 
    {
        players.ForEach((PlayerData player) =>
        {
            if (player.doorState == DoorState.CLOSED)
            {
                player.score.Value += 1;
            }
        });
    }

    bool isMatchWinner(PlayerData player) 
    {
        return player.score.Value >= player.maxScore.Value;
    }
}
