using UnityEngine;

public class Round : BaseState
{
    
    private GameStateMachine _sm;
    public Round(GameStateMachine stateMachine) : base("Round", stateMachine) 
    {
        _sm = stateMachine;
        _sm.gameEvents.roundStartEvent.AddListener(() => _sm.ChangeState(this));
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Round");
        _sm.gameEvents.startTimerEvent?.Invoke();
    }

    public override void UpdateLogic() 
    {

    }
}