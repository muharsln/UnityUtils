using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.UserInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _inputDataArray;
        [SerializeField] private FixedJoystick _joysticks;

        private void Update()
        {
            for (int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcessInput(_joysticks.Horizontal, _joysticks.Vertical);
            }
        }
    }
}