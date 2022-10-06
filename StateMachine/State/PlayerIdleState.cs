using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : AbstractPlayerAnimationBaseState
{
    public override void UpdateState(PlayerAnimationStateManager player)
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Run", true);
            player.SwitchState(player.PlayerRunState);
        }
    }
}