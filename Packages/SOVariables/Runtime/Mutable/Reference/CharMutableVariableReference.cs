using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class CharMutableVariableReference : MutableVariableReference<char>
    {
        [SerializeField] private CharMutableVariable charMutableVariable;

        protected override MutableVariable<char> Reference => charMutableVariable;
    }
}
