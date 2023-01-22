
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundEnd : BaseState
{
    private GameStateMachine _sm;
    public RoundEnd(GameStateMachine stateMachine) : base("RoundEnd", stateMachine) {
        _sm = stateMachine;
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering RoundEnd");
    }
}