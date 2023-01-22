using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine : StateMachine
{
    [HideInInspector]
    public TitleScreen titleScreenState;
    [HideInInspector]
    public Tutorial tutorialState;

    private void Awake()
    {
        titleScreenState = new TitleScreen(this);
        tutorialState = new Tutorial(this);
    }

    protected override BaseState GetInitialState()
    {
        return titleScreenState;
    }
}