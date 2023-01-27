using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class UIntMutableVariableReference : MutableVariableReference<uint>
    {
        [SerializeField] private UIntMutableVariable uintMutableVariable;

        protected override MutableVariable<uint> Reference => uintMutableVariable;
    }
}
