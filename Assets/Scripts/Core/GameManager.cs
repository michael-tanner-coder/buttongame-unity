using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameManager : MonoBehaviour
{

    // ARCHITECTURE (consider if necessary)
    // TODO: review unity architecture vid
    // TODO: implement SO event architecture???
    // TODO: implement SO variables
    // TODO: address race conditions in event responses
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
    private ScriptableObjectArchitecture.StateReference _state;
    private bool roundEnded = false;

    [SerializeField]
    private GameObjectCollection _playerPrefabs = default(GameObjectCollection);

    [SerializeField]
    private List<PlayerData> players;

    [SerializeField]
    private GameEvents _gameEvents;

    [SerializeField]
    private ScriptableObjectArchitecture.GameEvent testEvent;

    [SerializeField]
    private ScriptableObjectArchitecture.IntVariable _maxScore;

    void Awake() 
    {
        _gameEvents.roundEndEvent.AddListener(CheckForWinner);
        ResetPlayerData();
    }

    void ResetPlayerData()
    {
        players.ForEach((PlayerData player) => {
            player.ResetData();
        });
    }

    PlayerData GetRoundWinner() 
    {
        // PlayerData winner;
        PlayerData winner = null;
        players.ForEach((PlayerData player) =>
        {
            if (player.doorState == DoorState.CLOSED)
            {
                // output winner
                Debug.Log("Round Winner is " + player.playerName);

                // update score
                player.score.Value += 1;
                winner = player;
            }
        });

        return winner;
    }


    void CheckForMatchWinner(PlayerData winningPlayer) 
    {
        PlayerData matchWinner = null;

        // if a player's score exceeds the max score, the game is over
        if (isMatchWinner(winningPlayer))
        {
            // move to game over state
            _gameEvents.gameOverEvent?.Invoke();
            ResetPlayerData();

            // output match winner
            Debug.Log("Match Winner is " + winningPlayer.playerName);

            matchWinner = winningPlayer;
        }
    
        // if no one won the match, go back to round start state
        if (matchWinner == null)
        {
            _gameEvents.roundStartEvent?.Invoke();
        }
    }

    public void TestEvent()
    {
        Debug.Log("Test Event Raised");
    }

    void CheckForWinner() 
    {
        // if a player won the round, check if they also won the whole match
        PlayerData roundWinner = GetRoundWinner();
        if (roundWinner != null)
        {
            CheckForMatchWinner(roundWinner);
            return;
        }
    
        // otherwise, do another round
        _gameEvents.roundStartEvent?.Invoke();
    }
    bool isMatchWinner(PlayerData player) 
    {
        return player.score.Value >= _maxScore.Value;
    }
}
