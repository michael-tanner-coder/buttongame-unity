
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : BaseState
{
    private GameStateMachine _sm;
    public Countdown(GameStateMachine stateMachine) : base("Countdown", stateMachine) {
        _sm = stateMachine;
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Countdown");
    }
}