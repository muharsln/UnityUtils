using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : AbstractPlayerAnimationBaseState
{
    public override void UpdateState(PlayerAnimationStateManager player)
    {
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Run", false);
            player.SwitchState(player.PlayerIdleState);
        }
    }
}
