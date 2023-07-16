using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class LongArrayMutableVariableReference : MutableVariableReference<long[]>
    {
        [SerializeField] private LongArrayMutableVariable longArrayMutableVariable;

        protected override MutableVariable<long[]> Reference => longArrayMutableVariable; 
    }
}
