using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ByteArrayMutableVariableReference : MutableVariableReference<byte[]>
    {
        [SerializeField] private ByteArrayMutableVariable byteArrayMutableVariable;

        protected override MutableVariable<byte[]> Reference => byteArrayMutableVariable; 
    }
}
