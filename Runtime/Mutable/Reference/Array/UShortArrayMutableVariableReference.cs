using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class UShortArrayMutableVariableReference : MutableVariableReference<ushort[]>
    {
        [SerializeField] private UShortArrayMutableVariable uShortArrayMutableVariable;

        protected override MutableVariable<ushort[]> Reference => uShortArrayMutableVariable; 
    }
}
