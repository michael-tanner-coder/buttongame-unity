
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : BaseState
{
    private GameStateMachine _sm;
    public Tutorial(GameStateMachine stateMachine) : base("Tutorial", stateMachine) {
        _sm = stateMachine;
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Tutorial");
    }
}