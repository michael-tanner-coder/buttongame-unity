using UnityEngine;

public class StateEnums
{
    public new enum States {}
}

public class GameStates: StateEnums {
    public new enum Enums
    {
        TUTORIAL,
        NEXT_BOMB,
        COUNTDOWN,
        ROUND_START,
        ROUND_END,
        GAME_OVER,
        TITLE_SCREEN
    }
}

public class ButtonStates: StateEnums {
    public new enum Enums
    {
        UNPRESSED,
        PRESSED,
        RELEASED
    }
}

public class DoorStates: StateEnums {
    public new enum Enums
    {
      OPEN, 
      CLOSED
    }
}