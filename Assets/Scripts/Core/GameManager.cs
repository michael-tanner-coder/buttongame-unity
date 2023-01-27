using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // ARCHITECTURE (consider if necessary)
    // TODO: review unity architecture vid
    // TODO: implement SO event architecture???
    // TODO: implement SO variables
    // TODO: address race conditions in event responses
    // TODO: split up enums into different files / classes
    // TODO: provider public getters for SO values

    // LOGIC
    // TODO: create feature toggles to enable/disable certain game elements (event types, obstacles, collectibles)
    // TODO: spawn explosion object on round end
    // TODO: end round on collision with small bomb

    // ANIMATION
    // TODO: create countdown animation
    // TODO: create bomb tween animation
    // TODO: create player lose animation
    // TODO: create door animation
    // TODO: create explosion animation
    
    // GRAPHICS/UI
    // TODO: display winner UI / get winning player
    // TODO: adjust UI to fit display
    // TODO: get pixel-perfect unity display

    // SOUND
    // TODO: use SOs to act as a sound manager
    // TODO: load sound assets into SO
    // TODO: play music on start
    // TODO: switch music tempo based on player scores
    // TODO: pair sounds with actions (jumping, landing, button press, tick, explode, etc)

    [SerializeField]
    private GameState.Enums state;
    private bool roundEnded = false;

    [SerializeField]
    private PlayerData[] playerData;
    private Score[] scoreData;

    [SerializeField]
    private GameEvents _gameEvents;

    void Awake() 
    {
        _gameEvents.roundEndEvent.AddListener(CheckForWinner);
        ResetPlayerData();
    }

    void ResetPlayerData()
    {
        for(int i = 0; i < playerData.Length; i++)
        {
            playerData[i].ResetData();
        }
    }

    bool CheckForRoundWinner() 
    {
        bool winner = false;
        for (int i = 0; i < playerData.Length; i++)
        {
            if (playerData[i].doorState == DoorState.Enums.CLOSED)
            {
                // output round winner
                Debug.Log("Round Winner is " + playerData[i].playerName);

                playerData[i].score += 1;
                winner = true;

                // break early from loop so that we don't test win conditions for the other player
                break;
            }
        }

        return winner;
    }


    void CheckForMatchWinner() 
    {
        bool matchWinner = false;
        for (int i = 0; i < playerData.Length; i++)
        {
            // if a player's score exceeds the max score, the game is over
            if (isMatchWinner(playerData[i]))
            {
                // move to game over event
                _gameEvents.gameOverEvent?.Invoke();
                ResetPlayerData();

                // output match winner
                Debug.Log("Match Winner is " + playerData[i].playerName);

                matchWinner = true;

                // break early from loop so that we don't test win conditions for the other player
                break;
            }

        }
    
        if (!matchWinner)
        {
            _gameEvents.roundStartEvent?.Invoke();
        }
    }


    void CheckForWinner() 
    {
        // if a player won the round, check if the also won the whole match
        if (CheckForRoundWinner())
        {
            CheckForMatchWinner();
        }
        else 
        {
            // otherwise, do another round
            _gameEvents.roundStartEvent?.Invoke();
        }
        
    }
    bool isMatchWinner(PlayerData player) 
    {
        return player.score >= 3;
    }
}
