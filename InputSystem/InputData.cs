using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Project.UserInput
{
    [CreateAssetMenu(menuName = "Rapidball/Input/Input Data")]
    public class InputData : AbstractScriptableInputData
    {
        [SerializeField] private float _horizontal;
        public float Horizontal { get { return _horizontal; } }

        [SerializeField] private float _vertical;
        public float Vertical { get { return _vertical; } }

        public override void ProcessInput(float horizontal, float vertical)
        {
            _horizontal = horizontal;
            _vertical = vertical;
        }
    }
}