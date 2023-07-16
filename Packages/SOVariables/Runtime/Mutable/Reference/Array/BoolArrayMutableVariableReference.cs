using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class BoolArrayMutableVariableReference : MutableVariableReference<bool[]>
    {
        [SerializeField] private BoolArrayMutableVariable boolArrayMutableVariable;

        protected override MutableVariable<bool[]> Reference => boolArrayMutableVariable; 
    }
}
