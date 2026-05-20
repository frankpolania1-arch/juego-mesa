using UnityEngine;
// 6 referencias
public class PlayerStateMachine
{
    public IPlayerState currentState;
    // 3 referencias
    public void ChangeState(IPlayerState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
    // 1 referencia
    public void Update()
    {
        currentState?.Update();
    }
}