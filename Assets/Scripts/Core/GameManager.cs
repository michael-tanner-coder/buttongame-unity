using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // TODO: test movement between states for specific actions (timer runs out, animation ends, input is pressed, etc)
    // TODO: create feature toggles to enable/disable certain game elements (event types, obstacles, collectibles)

    [SerializeField]
    private GameState.Enums state;

    [SerializeField]
    private PlayerData[] playerData;
}
