using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ByteMutableVariableReference : MutableVariableReference<byte>
    {
        [SerializeField] private ByteMutableVariable byteMutableVariable;

        protected override MutableVariable<byte> Reference => byteMutableVariable;
    }
}
