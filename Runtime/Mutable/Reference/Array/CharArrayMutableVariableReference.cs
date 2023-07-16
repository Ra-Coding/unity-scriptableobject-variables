using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class CharArrayMutableVariableReference : MutableVariableReference<char[]>
    {
        [SerializeField] private CharArrayMutableVariable charArrayMutableVariable;

        protected override MutableVariable<char[]> Reference => charArrayMutableVariable; 
    }
}
