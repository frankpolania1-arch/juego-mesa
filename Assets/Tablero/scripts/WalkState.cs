using UnityEngine;

public class WalkState : IPlayerState
{
    private PlayerManager player;
    private PlayerStateMachine stateMachine;
    // 1 referencia
    public WalkState(PlayerManager player, PlayerStateMachine stateMachine)
    {
        this.player = player;
        this.stateMachine = stateMachine;
    }
    // 2 referencias
    public void Enter()
    {
        player.animator.Play("Walk");
    }
    // 2 referencias
    public void Update()
    {
        if (player.mover == false)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
    // 2 referencias
    public void Exit()
    {
        Debug.Log("EXIT WALK");
    }
}