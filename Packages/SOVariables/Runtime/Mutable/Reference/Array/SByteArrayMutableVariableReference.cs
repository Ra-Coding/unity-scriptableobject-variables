using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class SByteArrayMutableVariableReference : MutableVariableReference<sbyte[]>
    {
        [SerializeField] private SByteArrayMutableVariable sByteArrayMutableVariable;

        protected override MutableVariable<sbyte[]> Reference => sByteArrayMutableVariable; 
    }
}
