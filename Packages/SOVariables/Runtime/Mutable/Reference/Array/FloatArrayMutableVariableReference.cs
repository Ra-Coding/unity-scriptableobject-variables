using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class FloatArrayMutableVariableReference : MutableVariableReference<float[]>
    {
        [SerializeField] private FloatArrayMutableVariable floatArrayMutableVariable;

        protected override MutableVariable<float[]> Reference => floatArrayMutableVariable; 
    }
}
