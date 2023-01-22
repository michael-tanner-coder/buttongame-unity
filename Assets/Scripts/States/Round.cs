
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : BaseState
{
    
    private GameStateMachine _sm;
    public Round(GameStateMachine stateMachine) : base("Round", stateMachine) {
        _sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Round");
    }

    public override void UpdateLogic() 
    {

    }
}