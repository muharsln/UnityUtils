using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.UserInput
{
    public abstract class AbstractScriptableInputData : ScriptableObject
    {
        public abstract void ProcessInput(float horizontal, float vertical);
    }
}