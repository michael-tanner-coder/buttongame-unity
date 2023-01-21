using UnityEngine;

public class States : MonoBehaviour
{
    public enum GameState
    {
        TUTORIAL,
        NEXT_BOMB,
        COUNTDOWN,
        ROUND_START,
        ROUND_END,
        GAME_OVER,
        TITLE_SCREEN
    }

    public enum PlayerState 
    {
        JUMPING,
        FALLING,
        GROUNDED,
        STUNNED
    }

    public enum ButtonState 
    {
        UNPRESSED,
        PRESSED,
        RELEASED
    }

    public enum DoorState
    {
        OPEN,
        CLOSED
    }
}