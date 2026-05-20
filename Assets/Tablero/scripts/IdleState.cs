using UnityEngine;
// 3 referencias
public class IdleState : IPlayerState
{
    private PlayerManager player;
    private PlayerStateMachine stateMachine;
    // 1 referencia
    public IdleState(PlayerManager player, PlayerStateMachine stateMachine)
    {
        this.player = player;
        this.stateMachine = stateMachine;
    }
    // 2 referencias
    public void Enter()
    {
        player.animator.Play("idle");
    }
    // 2 referencias
    public void Update()
    {
        if (player.mover)
        {
            stateMachine.ChangeState(player.walkState);
        }
    }
    // 2 referencias
    public void Exit()
    {
        Debug.Log("EXIT IDLE");
    }
}