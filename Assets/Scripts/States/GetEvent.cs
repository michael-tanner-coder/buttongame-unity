
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEvent : BaseState
{
    private GameStateMachine _sm;
    public GetEvent(GameStateMachine stateMachine) : base("GetEvent", stateMachine) {
        _sm = stateMachine;
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering GetEvent");
    }
}