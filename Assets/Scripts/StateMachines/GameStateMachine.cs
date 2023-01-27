using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateMachine : StateMachine
{
    // states
    [HideInInspector]
    public TitleScreen titleScreenState;

    [HideInInspector]
    public Tutorial tutorialState;

    [HideInInspector]
    public Countdown countdownState;

    [HideInInspector]
    public GetGameMode getGameMode;

    [HideInInspector]
    public Round roundState;

    [HideInInspector]
    public RoundEnd roundEndState;

    [HideInInspector]
    public GameOver gameOverState;

    // current game mode
    public GameMode gameMode;

    // events
    public GameEvents gameEvents;

    // input
    PlayerInput input;
    public PlayerInput Input => input;


    private void Awake()
    {
        titleScreenState = new TitleScreen(this);
        tutorialState = new Tutorial(this);
        roundState = new Round(this);
        roundEndState = new RoundEnd(this);
        gameOverState = new GameOver(this);
        input = GetComponent<PlayerInput>();
    }

    protected override BaseState GetInitialState()
    {
        return roundState;
    }
}