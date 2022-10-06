using UnityEngine;

public abstract class AbstractPlayerAnimationBaseState
{
    protected Animator animator;
    public abstract void UpdateState(PlayerAnimationStateManager player);
    public virtual void StartState(PlayerAnimationStateManager player)
    {
        animator = player.GetComponent<Animator>();
    }
}