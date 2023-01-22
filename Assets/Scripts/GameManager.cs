using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // TODO: test movement between states for specific actions (timer runs out, animation ends, input is pressed, etc)
    // TODO: use an event system to speak to all gameobjects in a scene (players, bomb, scores, etc)
    // TODO: create "special event" types for the different game modes so that we can switch easily (standard, sudden death, moving bomb, etc)
    // TODO: create feature toggles to enable/disable certain game elements (event types, obstacles, collectibles)

    [SerializeField]
    private GameStates.Enums state;
}
