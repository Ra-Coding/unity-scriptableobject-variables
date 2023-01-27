using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class StringMutableVariableReference : MutableVariableReference<string>
    {
        [SerializeField] private StringMutableVariable stringMutableVariable;

        protected override MutableVariable<string> Reference => stringMutableVariable;
    }
}
