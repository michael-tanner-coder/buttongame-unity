public class StateEnums
{
    public enum States {}
}

public class GameState: StateEnums {
    public enum Enums
    {
        TUTORIAL,
        GET_EVENT,
        COUNTDOWN,
        ROUND,
        ROUND_END,
        GAME_OVER,
        TITLE_SCREEN
    }
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