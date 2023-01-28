using System.Collections.Generic;
using UnityEngine;
public class GetWinner : MonoBehaviour
{

    [SerializeField]
    private List<PlayerData> players;

    public void OnRoundEnd()
    {
        players.ForEach((player) =>
        {
            if (isMatchWinner(player))
            {
                Debug.Log("Winner!");
            }
            else 
            {
                Debug.Log("Not Winner!");
            }
        });
    }
    bool isMatchWinner(PlayerData player) 
    {
        return player.score.Value >= player.maxScore.Value;
    }
}
