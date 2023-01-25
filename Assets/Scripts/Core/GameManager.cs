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
        _gameEvents.roundEndEvent.AddListener(EndRound);
        _gameEvents.gameOverEvent.AddListener(CheckForMatchWinner);
    }

    void EndRound() 
    {
        roundEnded = true;
    }

    void CheckForRoundWinner() 
    {
        for (int i = 0; i < playerData.Length; i++)
        {
            if (playerData[i].doorState == DoorState.Enums.CLOSED)
            {
                // output winner
                Debug.Log("Round Winner is " + playerData[i].playerName);
                
                // break early from loop so that we don't test win conditions for the other player
                break;
            }
        }

    }

    void CheckForMatchWinner() 
    {
        for (int i = 0; i < playerData.Length; i++)
        {
            if (playerData[i].score >= 3) 
            {
                Debug.Log("Match Winner is " + playerData[i].playerName);
                
                break;
            }
        }
    }

    void Update() 
    {
    }
}
