using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameReset : MonoBehaviour
{

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
    private GameObjectCollection _playerPrefabs = default(GameObjectCollection);

    [SerializeField]
    private List<PlayerData> players;

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
}






