using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationStateManager : MonoBehaviour
{
    private AbstractPlayerAnimationBaseState _currentAnimationState;

    public PlayerIdleState PlayerIdleState = new PlayerIdleState();
    public PlayerRunState PlayerRunState = new PlayerRunState();
    public PlayerDeadState PlayerDeadState = new PlayerDeadState();

    private void Start()
    {
        _currentAnimationState = PlayerIdleState;
        _currentAnimationState.StartState(this);
    }

    private void Update()
    {
        _currentAnimationState.UpdateState(this);
    }

    public void SwitchState(AbstractPlayerAnimationBaseState state)
    {
        _currentAnimationState = state;
        state.StartState(this);
    }
}
