using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Player
{
    public class SkillManager : MonoSingleton<SkillManager>
    {
        public event Action<PlayerSkillController> Dash;

        public void DashButton()
        {
            Dash?.Invoke(PlayerSkillController.Instance);
        }
    }
}