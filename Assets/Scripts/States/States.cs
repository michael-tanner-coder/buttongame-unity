using UnityEngine;

public class StateEnums
{
    public enum States {}
}

public class GameStates: StateEnums {
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

public class ButtonStates: StateEnums {
    public enum Enums
    {
        UNPRESSED,
        PRESSED,
        RELEASED
    }
}

public class DoorStates: StateEnums {
    public enum Enums
    {
      OPEN, 
      CLOSED
    }
}