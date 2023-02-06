using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GetWinner : MonoBehaviour
{

    [SerializeField]
    private List<PlayerData> players;

    [SerializeField]
    private PlayerDataVariable _winner;

    [SerializeField]
    private ScriptableObjectArchitecture.GameEvent startRound;

    [SerializeField]
    private ScriptableObjectArchitecture.GameEvent endMatch;

    [SerializeField]
    private float _delayBetweenRounds = 1f;


    IEnumerator DelayRoundChange() 
    {
        yield return new WaitForSeconds(_delayBetweenRounds);
        startRound.Raise();
    }
    public void OnRoundEnd()
    {
        bool foundMatchWinner = false;

        UpdateScores();

        players.ForEach((player) =>
        {
            if (isMatchWinner(player))
            {
                Debug.Log("Winner!");
                Debug.Log(player.playerName);
                foundMatchWinner = true;
                _winner.Value = player;
                endMatch.Raise();
            }
        });
        

        if (!foundMatchWinner)
        {
            StartCoroutine(DelayRoundChange());
        }
    }

    void UpdateScores() 
    {
        players.ForEach((PlayerData player) =>
        {
            if (player.doorState == DoorState.CLOSED)
            {
                // output winner
                Debug.Log("Round Winner is " + player.playerName);

                // update score
                player.score.Value += 1;
            }
        });
    }

    bool isMatchWinner(PlayerData player) 
    {
        return player.score.Value >= player.maxScore.Value;
    }
}
