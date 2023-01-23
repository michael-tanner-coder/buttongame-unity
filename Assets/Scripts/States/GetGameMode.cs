
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGameMode : BaseState
{
    private GameStateMachine _sm;
    public GetGameMode(GameStateMachine stateMachine) : base("GetGameMode", stateMachine) {
        _sm = stateMachine;
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering GetGameMode");
    }
}