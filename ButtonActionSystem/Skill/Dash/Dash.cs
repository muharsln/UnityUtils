using Rapidball.UserInput;
using System.Collections;
using UnityEngine;

namespace Project.Player
{
    public class Dash : MonoBehaviour
    {
        private void Start()
        {
            SkillManager.Instance.Dash += PlayerDash;
        }

        private void PlayerDash(PlayerSkillController player)
        {
            Debug.Log("Dash");
        }
    }
}