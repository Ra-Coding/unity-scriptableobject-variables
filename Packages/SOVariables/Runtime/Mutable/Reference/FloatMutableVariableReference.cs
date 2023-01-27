using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class FloatMutableVariableReference : MutableVariableReference<float>
    {
        [SerializeField] private FloatMutableVariable floatMutableVariable;

        protected override MutableVariable<float> Reference => floatMutableVariable;
    }
}
