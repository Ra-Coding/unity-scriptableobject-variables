using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class UIntArrayMutableVariableReference : MutableVariableReference<uint[]>
    {
        [SerializeField] private UIntArrayMutableVariable uIntArrayMutableVariable;

        protected override MutableVariable<uint[]> Reference => uIntArrayMutableVariable; 
    }
}
