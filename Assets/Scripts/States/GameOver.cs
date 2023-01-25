
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : BaseState
{
    private GameStateMachine _sm;
    public GameOver(GameStateMachine stateMachine) : base("GameOver", stateMachine) {
        _sm = stateMachine;
        _sm.gameEvents.gameOverEvent.AddListener(() => _sm.ChangeState(this));
     }

     public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering GameOver");
    }
}