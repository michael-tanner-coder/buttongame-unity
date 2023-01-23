using UnityEngine;

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

public class ButtonState: StateEnums {
    public enum Enums
    {
        UNPRESSED,
        PRESSED,
        RELEASED
    }
}

public class DoorState: StateEnums {
    public enum Enums
    {
      OPEN, 
      CLOSED
    }
}