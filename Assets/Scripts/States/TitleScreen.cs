
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : BaseState
{
    private GameStateMachine _sm;
    public TitleScreen(GameStateMachine stateMachine) : base("TitleScreen", stateMachine) {
        _sm = stateMachine;
    }


    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Title screen");
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        stateMachine.ChangeState(_sm.tutorialState);
    }
}