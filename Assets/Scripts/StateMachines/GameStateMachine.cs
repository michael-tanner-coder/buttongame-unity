using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GetEvent getEventState;
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

    private void Start() 
    {
        gameEvents.roundEndEvent?.AddListener(RoundEnd);
    }

    private void RoundEnd() 
    {
        Debug.Log("Manager: Round End");
    }

    private void Awake()
    {
        titleScreenState = new TitleScreen(this);
        tutorialState = new Tutorial(this);
        roundState = new Round(this);
    }

    protected override BaseState GetInitialState()
    {
        return roundState;
    }
}